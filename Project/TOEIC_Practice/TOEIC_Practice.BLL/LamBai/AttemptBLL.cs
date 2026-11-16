using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TOEIC_Practice.DAL.LamBai;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.BLL.LamBai
{
    public class AttemptBLL
    {
        private readonly AttemptDAL _dal = new AttemptDAL();

        public int StartAttempt(int accountId, int testId, List<int> partIds, int? timeLimitMinutes)
        {
            if (partIds == null || partIds.Count == 0) partIds = new List<int> { 5 };
            string csv = string.Join(",", partIds);
            return _dal.StartAttempt(accountId, testId, csv, timeLimitMinutes);
        }

        /// <summary>
        /// Lấy toàn bộ câu hỏi + đáp án (4 đáp án) theo AttemptId.
        /// Trả về:
        /// - questions: danh sách câu (mỗi câu 1 DTO)
        /// - optionsMap: map AttemptQuestionId -> 4 options
        /// </summary>
        public List<AttemptQuestionDTO> GetQuestionList(int attemptId, out Dictionary<int, List<AttemptOptionDTO>> optionsMap)
        {
            DataTable dt = _dal.GetQuestionListRaw(attemptId);

            optionsMap = new Dictionary<int, List<AttemptOptionDTO>>();
            var questions = new List<AttemptQuestionDTO>();
            var seen = new HashSet<int>();

            foreach (DataRow row in dt.Rows)
            {
                int aqId = (int)row["AttemptQuestionId"];

                // 1) Add question 1 lần
                if (!seen.Contains(aqId))
                {
                    questions.Add(new AttemptQuestionDTO(row));
                    seen.Add(aqId);
                }

                // 2) Add option
                var opt = new AttemptOptionDTO(row);
                if (!optionsMap.ContainsKey(aqId))
                    optionsMap[aqId] = new List<AttemptOptionDTO>();

                optionsMap[aqId].Add(opt);
            }

            // sort options
            foreach (var key in optionsMap.Keys.ToList())
                optionsMap[key] = optionsMap[key].OrderBy(x => x.DisplayOrder).ToList();

            return questions.OrderBy(x => x.OrderNo).ToList();
        }

        public void SaveAnswer(int attemptQuestionId, string optionLabel)
        {
            if (string.IsNullOrWhiteSpace(optionLabel)) optionLabel = null;
            _dal.SaveAnswer(attemptQuestionId, optionLabel);
        }

        public AttemptSummaryDTO SubmitAttempt(int attemptId)
        {
            DataTable dt = _dal.SubmitAttemptRaw(attemptId);
            if (dt.Rows.Count == 0) throw new Exception("Không lấy được kết quả nộp bài.");
            return new AttemptSummaryDTO(dt.Rows[0]);
        }

        public int StartAttempt(int accountId, int testId, string partIdsCsv, int? timeLimitMinutes)
        {
            if (accountId <= 0) throw new System.Exception("AccountId không hợp lệ.");
            if (testId <= 0) throw new System.Exception("TestId không hợp lệ.");
            if (string.IsNullOrWhiteSpace(partIdsCsv)) partIdsCsv = "5";

            int attemptId = _dal.StartAttempt(accountId, testId, partIdsCsv, timeLimitMinutes);
            if (attemptId <= 0) throw new System.Exception("Không tạo được Attempt.");

            return attemptId;
        }
        public List<AttemptPart7GroupDTO> GetPart7Groups(
            int attemptId,
            out Dictionary<int, List<AttemptOptionDTO>> optionsMap)
        {
            // 1) Lấy toàn bộ question + option như cũ
            List<AttemptQuestionDTO> allQuestions = GetQuestionList(attemptId, out optionsMap);

            // 2) Lọc riêng Part 7
            var part7Questions = allQuestions
                .Where(x => x.PartId == 7)
                .OrderBy(x => x.GroupOrderNo)
                .ThenBy(x => x.OrderNo)
                .ToList();

            // 3) Lấy passages
            DataTable dtPassages = _dal.GetGroupPassagesRaw(attemptId, 7);
            List<AttemptPassageDTO> passages = new List<AttemptPassageDTO>();

            foreach (DataRow row in dtPassages.Rows)
                passages.Add(new AttemptPassageDTO(row));

            // 4) Group theo GroupId
            var result = part7Questions
                .GroupBy(q => q.GroupId)
                .Select(g => new AttemptPart7GroupDTO
                {
                    GroupId = g.Key,
                    GroupOrderNo = g.First().GroupOrderNo,
                    GroupType = g.First().GroupType,
                    Questions = g.OrderBy(x => x.OrderNo).ToList(),
                    Passages = passages
                        .Where(p => p.GroupId == g.Key)
                        .OrderBy(p => p.PassageNo)
                        .ToList()
                })
                .OrderBy(x => x.GroupOrderNo)
                .ToList();

            return result;
        }
    }
}