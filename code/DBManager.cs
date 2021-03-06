using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using utilityfunctions;

namespace CentralLibrary
{
    public class DBManager
    {

		// add your connection string.
        static string DB_Connection_String = @"";

        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open(); //Open a connection with the DB
                Console.WriteLine("Successfully connected to the database!");
            }
            catch
            {
                Console.WriteLine("An error occurred while connecting to the database!");
            }
        }

        public int ExecuteNonQuery(string query, params parameterToAProcedure[] parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                if (parameters != null)
                {
                    foreach (parameterToAProcedure o in parameters)
                    {
                        myCommand.Parameters.AddWithValue(o.name, o.value);
                    }
                }
                return myCommand.ExecuteNonQuery() + 1;
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReaderStoredProcedure(string storedprocedure, params parameterToAProcedure[] parameters)
        {
            try
            {
                
                SqlCommand myCommand = new SqlCommand(storedprocedure, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (parameterToAProcedure o in parameters)
                    {
                        myCommand.Parameters.AddWithValue(o.name, o.value);
                    }
                }
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                } else
                {
                    reader.Close();
                    return null;
                }
                
            } catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
                return null;
            } 
        }


        public int ExecuteNonStoredProcedure(string storedprocedure, params parameterToAProcedure[] parameters)
        {
            try
            {

                SqlCommand myCommand = new SqlCommand(storedprocedure, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (parameterToAProcedure o in parameters)
                    {
                        myCommand.Parameters.AddWithValue(o.name, o.value);
                    }
                }
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                Console.WriteLine(ex.Message);
            }
        }


    }
}
