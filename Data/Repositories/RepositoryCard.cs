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
    public class RepositoryCard:RepositoryBase
    {
        //const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        //const string connString = @"SERVER = KUBO\SQLEXPRESS; DATABASE = ISLAMBANK; Trusted_Connection = true ";
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
        public bool CheckCard(int Login, string Pin)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = "select * from [CARD]";
                        SqlCommand commandSlct = new SqlCommand(sqlQuery, connection);
                        using (SqlDataReader reader = commandSlct.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0).Equals(Login))
                                {
                                    if (reader.GetString(1).Equals(Pin))
                                    {
                                        if (!reader.GetBoolean(5))
                                        {
                                            if (reader.GetDateTime(4)>=DateTime.Now)
                                            {
                                                return true;
                                            }
                                        }

                                    }
                                }
                            }
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
        public bool BlockCard( int cardId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @" update [CARD]  set blocked= 1 where id=@cardId";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@cardId", SqlDbType.Int).Value = cardId;
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
        public bool UnblockCard(int cardId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @" update [CARD]  set blocked= 0 where id=@cardId";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@cardId", SqlDbType.Int).Value = cardId;
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
        public bool CheckCurrentBalance(int Login, string Pin)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = "select * from [CARD]";
                        SqlCommand commandSlct = new SqlCommand(sqlQuery, connection);
                        using (SqlDataReader reader = commandSlct.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0).Equals(Login))
                                {
                                    if (reader.GetString(1).Equals(Pin))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }

                            }
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

