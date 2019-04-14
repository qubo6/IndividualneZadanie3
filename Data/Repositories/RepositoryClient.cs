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
    public class RepositoryClient
    {
        //const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        const string connString = @"SERVER = KUBO\SQLEXPRESS; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        public DataSet ClientBasicInfo(string CardIdentity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select ACCOUNT.id , First_Name as Name, Last_Name as Surname, IBAN, Validity_from as 'Card Validity',Open_date as 'Open date' , Balance from ((CLIENT as C left join [ADDRESS] as A on C.Address_id=A.Id)
                        left join ACCOUNT on ACCOUNT.Client_id=c.Id) 
                        left join [dbo].[CARD] on [dbo].[CARD].[Account_id]=ACCOUNT.Id where [Identity_card]= @IdentityCard ";
                    using( SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                        {
                        adapter.SelectCommand.Parameters.Add("@IdentityCard", SqlDbType.NVarChar).Value = CardIdentity;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Client");
                        return ds;
                        }                   
                }
            }
            catch (Exception )
            {
                throw;
            }          
        }

        public DataSet ClientCard(string CardIdentity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select Card_Number as 'Card Number' from ((CLIENT as C left join [ADDRESS] as A on C.Address_id=A.Id)
                        left join ACCOUNT on ACCOUNT.Client_id=c.Id) 
                        left join [dbo].[CARD] on [dbo].[CARD].[Account_id]=ACCOUNT.Id where [Identity_card]= @IdentityCard ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@IdentityCard", SqlDbType.NVarChar).Value = CardIdentity;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Client");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int AddClient(ModelClient modelClient, int addressId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into Client ([First_Name], [Last_Name] ,[Identity_card] ,[Address_id] ,[Email] ,[Phone_number]) 
                        values(@first, @last, @identitycard,@idAdrs ,@email, @phone)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@idAdrs", SqlDbType.Int).Value = addressId;
                        commandAdd.Parameters.Add("@first", SqlDbType.NVarChar).Value = modelClient.FirstName;
                        commandAdd.Parameters.Add("@last", SqlDbType.NVarChar).Value = modelClient.LastName;
                        commandAdd.Parameters.Add("@identitycard", SqlDbType.NVarChar).Value = modelClient.IdentityCard;
                        commandAdd.Parameters.Add("@email", SqlDbType.NVarChar).Value = modelClient.Email;
                        commandAdd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = modelClient.PhoneNumber;

                        if (commandAdd.ExecuteNonQuery() > 0)
                        {
                            using (SqlCommand command1 = connection.CreateCommand())
                            {
                                command1.CommandText = "Select @@Identity";
                                return Convert.ToInt32(command1.ExecuteScalar());
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }


    }
}
