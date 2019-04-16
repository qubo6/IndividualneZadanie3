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
    public class RepositoryAddress:RepositoryBase
    {
        //const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        //const string connString = @"SERVER = KUBO\SQLEXPRESS; DATABASE = ISLAMBANK; Trusted_Connection = true ";
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
        public ModelAddress SetForUpdate(int addressId)
        {
            ModelAddress modelForUpdate = new ModelAddress();
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"select 
                                        [Street]
                                      ,[City]
                                      ,[Postal_code]
                                        from [address] where id=@address";
                        SqlCommand commandSlct = new SqlCommand(sqlQuery, connection);
                        commandSlct.Parameters.Add("@address", SqlDbType.Int).Value = addressId;
                        using (SqlDataReader reader = commandSlct.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                modelForUpdate.Street = reader.GetString(0);
                                modelForUpdate.City = reader.GetString(1);
                                modelForUpdate.PostalCode = reader.GetString(2);                             
                                return modelForUpdate;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return modelForUpdate;
        }
        public DataSet OverViewDemography()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select top 5 city , count (city) as 'City count' from [address]  where city != 'bank' group by city	";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "[address]");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
