using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
namespace TOEIC_Practice.DAL.Helpers
{
    /// <summary>
    /// DataHelper - phiên bản TOEIC
    /// - Dùng ADO.NET + Stored Procedure
    /// - Trả về DataTable để map DTO(DataRow)
    /// - Có hỗ trợ Transaction (quan trọng cho nghiệp vụ Attempt)
    /// </summary>
    public class DataHelper
    {
        private static DataHelper _instance;

        public static DataHelper Instance
        {
            get
            {
                if (_instance == null) _instance = new DataHelper();
                return _instance;
            }
        }

        /// <summary>
        /// Chuỗi kết nối đọc từ App.config của project đang chạy (GUI)
        /// Name: ToeicDb
        /// </summary>
        public string ConnectionString { get; private set; }

        private DataHelper()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ToeicDb"]?.ConnectionString;

            // Nếu chưa cấu hình trong App.config thì fallback (chỉ để debug)
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                ConnectionString = "Data Source=DESKTOP-GKQID4P\\BUDDHA;Initial Catalog=TOEIC_PracticeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
            }
        }

        // =========================================================
        // 1) EXECUTE STORED PROCEDURE -> DATATABLE (SELECT)
        // =========================================================

        public DataTable ExecuteQuerySP(string spName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return ExecuteQuerySP(conn, null, spName, parameters);
            }
        }

        public DataTable ExecuteQuerySP(SqlConnection conn, SqlTransaction tran, string spName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // =========================================================
        // 2) EXECUTE STORED PROCEDURE -> NONQUERY (INSERT/UPDATE/DELETE)
        // =========================================================

        public int ExecuteNonQuerySP(string spName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return ExecuteNonQuerySP(conn, null, spName, parameters);
            }
        }

        public int ExecuteNonQuerySP(SqlConnection conn, SqlTransaction tran, string spName, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        // =========================================================
        // 3) EXECUTE STORED PROCEDURE -> SCALAR (TRẢ 1 GIÁ TRỊ)
        // =========================================================

        public object ExecuteScalarSP(string spName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return ExecuteScalarSP(conn, null, spName, parameters);
            }
        }

        public object ExecuteScalarSP(SqlConnection conn, SqlTransaction tran, string spName, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

        // =========================================================
        // 4) TRANSACTION: chạy nhiều bước, lỗi thì rollback
        // =========================================================

        public void ExecuteInTransaction(Action<SqlConnection, SqlTransaction> action)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        action(conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public T ExecuteInTransaction<T>(Func<SqlConnection, SqlTransaction, T> func)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        T result = func(conn, tran);
                        tran.Commit();
                        return result;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // =========================================================
        // 5) (TÙY CHỌN) SQL TEXT - chỉ dùng khi debug
        // =========================================================

        public DataTable ExecuteQueryText(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}