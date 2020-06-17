using io_sdk_csharp_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_sdk_csharp_dotnet
{
    public static class Repository
    {
        public static Data GetMessages(string connectionString)
        {
            var data = new Data();
            data.Messages = new List<Message>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT 0 AS amount, ");
                    sb.Append("scadenza AS due_date, ");
                    sb.Append("destinatario AS fiscal_code, ");
                    sb.Append("0 AS invalid_after_due_date, ");
                    sb.Append("testo AS markdown, ");
                    sb.Append("1 AS notice_number, ");
                    sb.Append("titolo AS subject ");
                    sb.Append("FROM Messages ");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var message = new Message();
                                message.Amount = (int)reader["amount"];
                                message.DueDate = (DateTime)reader["due_date"];
                                message.FiscalCode = reader["fiscal_code"].ToString();
                                message.InvalidAfterDueDate = (int)reader["invalid_after_due_date"];
                                message.Markdown = reader["markdown"].ToString();
                                message.NoticeNumber = (int)reader["notice_number"];
                                message.Subject = reader["subject"].ToString();

                                data.Messages.Add(message);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                // throw new ArgumentException("Errore nel recupero dei dati");
                data.Messages = null;
                data.Error = e.Message;
            }
            return data;
        }
    }
}