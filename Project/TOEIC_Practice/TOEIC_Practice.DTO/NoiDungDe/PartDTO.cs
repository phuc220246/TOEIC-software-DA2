using System;
using System.Data;

namespace TOEIC_Practice.DTO.NoiDungDe
{
    public class PartDTO
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public bool HasAudio { get; set; }
        public bool HasImage { get; set; }
        public int Section { get; set; } // 1=Listening, 2=Reading (nếu bạn có)

        // Chuỗi hiển thị trong CheckedListBox
        public string DisplayText => $"Part {PartId} - {PartName}";

        public PartDTO() { }

        public PartDTO(DataRow row)
        {
            PartId = Convert.ToInt32(row["PartId"]);
            PartName = row["PartName"] == DBNull.Value ? "" : row["PartName"].ToString();
            HasAudio = Convert.ToBoolean(row["HasAudio"]);
            HasImage = Convert.ToBoolean(row["HasImage"]);
            Section = Convert.ToInt32(row["Section"]);
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}