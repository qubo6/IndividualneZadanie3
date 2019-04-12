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
    public class RepositoryAddress
    {
        const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        public int AddAddress(ModelAddress modelAddress)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = "insert into [ADDRESS] (street,city, postal_code) values(@street, @city, @postcode)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@street", SqlDbType.NVarChar).Value = modelAddress.Street;
                        commandAdd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modelAddress.City;
                        commandAdd.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = modelAddress.PostalCode;

                        if (commandAdd.ExecuteNonQuery()>0)
                        {
                            using (SqlCommand command1 =connection.CreateCommand())
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
