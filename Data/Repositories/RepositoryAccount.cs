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
    public class RepositoryAccount : RepositoryBase
    {
        

        public bool AddAccount(ModelAccounts modelAccounts, int clientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(base.connString))
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
        public bool AtmFromClient(int accId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance - @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = accId;                        
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
        public bool AtmToBank(decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance + @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = 1;
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
        public DataSet CurrentBalnce(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select account.id, Balance as 'Own Assets', (select (sum(Balance+debit)) as 'Available Funds' from account left join [CARD] on [CARD].account_id = ACCOUNT.id where[CARD].id=@Id) from ((client left join [address] on client.address_id =[address].id)
                            left join  ACCOUNT on ACCOUNT.client_id=client.id)
                            left join [CARD] on [CARD].account_id = ACCOUNT.id where[CARD].id=@Id";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet BankAccount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select [IBAN]
                                      ,[Balance]
                                      ,[Debit]
                                      ,[Open_date] from account where ACCOUNT.id= 1";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet ClientAccount(int accId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select [IBAN]
                                      ,[Balance]
                                      ,[Debit]
                                      ,[Open_date] from account where ACCOUNT.id= @accId";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@accId", SqlDbType.Int).Value = accId;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet TransactionToClient(string iban)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select id,[IBAN]
                                      ,[Balance]
                                      ,[Debit]
                                      ,[Open_date] from account where ACCOUNT.iban= @iban";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@iban", SqlDbType.VarChar).Value = iban;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception )
            {
                return new DataSet();
            }
        }

        public bool ClientDeposit(int accId , decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance + @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = accId;
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
        public bool BankDeposit(decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance - @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = 1;
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
        public bool BankWithdrawal(decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance + @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = 1;
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
        public bool ClientWithdrawal(int accId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance - @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = accId;
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
        public bool TransactionSender(int senderId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance - @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = senderId;
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
        public bool TransactionRecepient(int recepientId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set balance = balance + @amount where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = recepientId;
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
        public DataSet OverViewBankAssets()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select sum(balance) as 'Total assets' from account where id>2";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet OverViewTop10Acc()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select top 10 first_name, last_name, iban, balance from account left join client on client.id=account.client_id 
                                    where account.id>1
                                    order by balance desc";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet OverViewActiveAcc()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select count(*) as 'Active accounts' from account where close_date is null and account.id>1";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet OverViewLast6months()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"SELECT COUNT (IBAN) AS 'Number of Accounts', DATEPART(YEAR,Open_Date) AS 'Year of Creation', 
                            Format(open_date,'MMMM') as 'Open month'  FROM Account where datediff(month,open_date,getdate())<6 GROUP BY DATEPART(YEAR,Open_Date),
                            Format(open_date,'MMMM') ORDER BY DATEPART(YEAR,Open_Date) DESC, Format(open_date,'MMMM') DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DebitEdit(int accId,decimal debit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set Debit = @debet where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@debet", SqlDbType.Decimal).Value = debit;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = accId;
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
        public bool CloseAccount(int accId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"update account set close_date = @close where id= @accid ";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@close", SqlDbType.DateTime).Value = DateTime.Now;
                        commandAdd.Parameters.Add("@accid", SqlDbType.Int).Value = accId;
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
        public DataSet AllAccounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select * from account";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "ACCOUNT");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public decimal MaxWithdrawal(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = "select sum(balance + debit) from account where id = @id";
                        SqlCommand commandSlct = new SqlCommand(sqlQuery, connection);
                        commandSlct.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        if (commandSlct.ExecuteScalar() !=null)
                        {
                            return (decimal)commandSlct.ExecuteScalar();
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
