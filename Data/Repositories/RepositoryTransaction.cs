using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RepositoryTransaction:RepositoryBase
    {
        //const string connString = @"SERVER = TRANSFORMER2\SQLEXPRESS2016; DATABASE = ISLAMBANK; Trusted_Connection = true ";
        public bool TransactionFromAtm( int clientId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into [TRANSACTION] (Id_sender ,Id_recipient ,Amount, Transaction_date,[Message]) 
                                values(@sender, @recipient, @amount,@date,@mess)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@sender", SqlDbType.Int).Value = clientId;
                        commandAdd.Parameters.Add("@recipient", SqlDbType.Int).Value = 1;
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                        commandAdd.Parameters.Add("@mess", SqlDbType.NVarChar).Value = "Withdrawal by ATM";

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
        public DataSet AllTransaction()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select t.transaction_date as 'Date' 
                                ,sender.iban as Sender 
                                ,recipient.iban as Recipient
                                , t.amount as Amount
                                , t.variable_symbol as 'Variable symbol'
                                , t.specific_symbol as 'Specific symbol'
                                , t.constant_symbol as 'Constant symbol'
                                , t.[Message]
                                from [transaction] as t
                                left join account as sender
                                on t.id_sender=sender.id
                                left join account as recipient
                                on t.id_recipient=recipient.id
                                order by transaction_date";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {                        
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "[TRANSACTION]");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet TransactionOfClient(int accId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string sqlQuery = @"select t.transaction_date as 'Date' 
                                ,sender.iban as Sender 
                                ,recipient.iban as Recipient
                                , t.amount as Amount
                                , t.variable_symbol as 'Variable symbol'
                                , t.specific_symbol as 'Specific symbol'
                                , t.constant_symbol as 'Constant symbol'
                                , t.[Message]
                                from [transaction] as t
                                left join account as sender
                                on t.id_sender=sender.id
                                left join account as recipient
                                on t.id_recipient=recipient.id
                                where recipient.id = @accId or sender.id=@accId
                                order by transaction_date";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@accId", SqlDbType.Int).Value = accId;
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "[TRANSACTION]");
                        return ds;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool TransactionDeposit(int accId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into [TRANSACTION] (Id_sender ,Id_recipient ,Amount, Transaction_date,[Message]) 
                                        values(@sender, @recipient, @amount,@date,@mess)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@sender", SqlDbType.Int).Value = 1;
                        commandAdd.Parameters.Add("@recipient", SqlDbType.Int).Value = accId;
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                        commandAdd.Parameters.Add("@mess", SqlDbType.NVarChar).Value = "Deposit";
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
        public bool TransactionWithdrawal(int accId, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into [TRANSACTION] (Id_sender ,Id_recipient ,Amount, Transaction_date,[Message]) 
                                values(@sender, @recipient, @amount,@date,@mess)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@sender", SqlDbType.Int).Value = accId;
                        commandAdd.Parameters.Add("@recipient", SqlDbType.Int).Value = 1;
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                        commandAdd.Parameters.Add("@mess", SqlDbType.NVarChar).Value = "Withdrawal";

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
        public bool Transaction(int accId_sender ,int accId_recipient, decimal amount, string vs, string ss, string ks, string mess)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string sqlQuery = @"insert into [TRANSACTION] (Id_sender ,Id_recipient ,Amount, Transaction_date,variable_symbol,specific_symbol,constant_symbol,[Message]) 
                                values(@sender, @recipient, @amount,@date,@vs,@ss,@ks,@mess)";
                        SqlCommand commandAdd = new SqlCommand(sqlQuery, connection);
                        commandAdd.Parameters.Add("@sender", SqlDbType.Int).Value = accId_sender;
                        commandAdd.Parameters.Add("@recipient", SqlDbType.Int).Value = accId_recipient;
                        commandAdd.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                        commandAdd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                        commandAdd.Parameters.Add("@mess", SqlDbType.NVarChar).Value = mess;
                        commandAdd.Parameters.Add("@vs", SqlDbType.VarChar).Value = vs;
                        commandAdd.Parameters.Add("@ss", SqlDbType.VarChar).Value = ss;
                        commandAdd.Parameters.Add("@ks", SqlDbType.VarChar).Value = ks;

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
