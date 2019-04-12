using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RepositoryAccount
    {
        const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        public bool AddAccount(ModelAccounts modelAccounts, int clientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into Account ([IBAN] ,[Open_date] ,[Client_id]) 
                                values(@iban, @open, @clientId)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@iban", SqlDbType.NVarChar).Value = modelAccounts.IBAN;
                        commandAdd.Parameters.Add("@open", SqlDbType.DateTime).Value = modelAccounts.OpenDate;
                        commandAdd.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;

                        if (commandAdd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

    }
}
