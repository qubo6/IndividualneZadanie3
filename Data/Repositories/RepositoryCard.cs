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
    public class RepositoryCard
    {
        const string connString = @"SERVER = KUBO\SQLEXPRESS; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        public bool AddCard(ModelCard modelCard, int accountId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into [CARD] (Card_Number,pin,Validity_from, Validity_until,Account_id) 
                                        values(@cardNumber, @pin, @validty_from, @validty_until, @account_id)
                                            ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = modelCard.CardNumber;
                        commandAdd.Parameters.Add("@pin", SqlDbType.Char).Value = modelCard.Pin;
                        commandAdd.Parameters.Add("@validty_from", SqlDbType.DateTime).Value = modelCard.Validity_from;
                        commandAdd.Parameters.Add("@validty_until", SqlDbType.DateTime).Value = modelCard.Validity_until;
                        commandAdd.Parameters.Add("@account_id", SqlDbType.Int).Value = accountId;

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
