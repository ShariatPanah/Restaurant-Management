using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Restaurant_Management.BLL;

namespace Restaurant_Management.DAL
{
    public class RestaurantManagementDAL
    {
        public static string ConnectionString =
            "Data Source=.;Initial Catalog=RestaurantManageMent;Integrated Security=True;";
        
        public static int Login(string User, string Pass)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select Count(Username) From [User] Where Username='{0}' And Password='{1}'", User, Pass);

                int Counter = (int)Command.ExecuteScalar();
                return Counter;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewUser(User oUser)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();

            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Insert into [User] Select @Username, @Password";

                Command.Parameters.AddWithValue("@Username", oUser.Username);
                Command.Parameters.AddWithValue("@Password", oUser.Password);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From [User]");

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteUser(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From [User] Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetInvoiceEntries()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = "Select * From Invoice";
                SqlDataReader Reader = Command.ExecuteReader();
                DataTable Table = new DataTable();

                Table.Load(Reader);
                return Table;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetFoodEntries()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = "Select * From Food";
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetSoldEntries()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = "Select * From SoldEntries";
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataSet GetAllEntries()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();
            try
            {
                Connection.Open();
                DataAdapter.SelectCommand = new SqlCommand();
                DataAdapter.SelectCommand.Connection = Connection;
                DataAdapter.SelectCommand.CommandType = CommandType.Text;
                DataAdapter.SelectCommand.CommandText = string.Format
                    ("Select FoodName, SoldEntries.[Count], SoldEntries.PriceForOne, Invoice.InvoiceAmount,Invoice.InvoiceDate, Invoice.TableNo, Invoice.InvoiceNo from Invoice, SoldEntries Where Invoice.ID=Invoice_ID");

                DataAdapter.Fill(oDataSet);

                return oDataSet;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Food RetrieveFood(int _ID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"RetrieveFoods";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters["@ID"].Value = _ID;

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                //Command.ExecuteNonQuery();

                Food oFood = new Food();
                oFood.FoodCode = Convert.ToInt32(Table.Rows[0]["FoodCode"]);
                oFood.FoodName = Convert.ToString(Table.Rows[0]["FoodName"]);
                oFood.Price = Convert.ToInt32(Table.Rows[0]["Price"]);

                return oFood;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Food RetrieveByCode(int _FoodCode)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = string.Format("Select * from Food Where FoodCode={0}", _FoodCode);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                Food oFood = new Food();
                oFood.FoodCode = Convert.ToInt32(Table.Rows[0]["FoodCode"]);
                oFood.FoodName = Convert.ToString(Table.Rows[0]["FoodName"]);
                oFood.Price = Convert.ToInt64(Table.Rows[0]["Price"]);

                return oFood;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetSoldEntries(int _invoiceId)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.CommandType = CommandType.Text;
                Command.CommandText = string.Format("Select * From SoldEntries Where Invoice_ID={0}", _invoiceId);
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State!=ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertFactor(Invoice Obj)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertFactor";

                Command.Parameters.AddWithValue("@FoodCode", Obj.FoodCode);
                Command.Parameters.AddWithValue("@FNo", Obj.InvoiceNo);
                Command.Parameters.AddWithValue("FType", Obj.InvoiceType);
                Command.Parameters.AddWithValue("@TNo", Obj.TableNo);
                Command.Parameters.AddWithValue("@Count", Obj.FoodCount);
                Command.Parameters.AddWithValue("@Price", Obj.PriceForOne);
                Command.Parameters.AddWithValue("Amount", Obj.Amount);
                Command.Parameters.AddWithValue("@Date", Obj.InvoiceDate);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertSoldEntries(SoldEntries Obj)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertSoldEntries";

                Command.Parameters.AddWithValue("@FoodName", Obj.FoodName);
                Command.Parameters.AddWithValue("@Count", Obj.FoodCount);
                Command.Parameters.AddWithValue("@Price", Obj.PriceForOne);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertFoods(Food Obj)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertFood";

                Command.Parameters.AddWithValue("@FoodName", Obj.FoodName);
                Command.Parameters.AddWithValue("@FoodCode", Obj.FoodCode);
                Command.Parameters.AddWithValue("@Price", Obj.Price);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State!=ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteFoodRow(int _id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"DeleteFood";

                Command.Parameters.AddWithValue("@ID", _id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateFood(int _id, Food Obj)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"UpdateFoods";

                Command.Parameters.AddWithValue("@ID", _id);
                Command.Parameters.AddWithValue("@FoodName", Obj.FoodName);
                Command.Parameters.AddWithValue("@FoodCode", Obj.FoodCode);
                Command.Parameters.AddWithValue("@Price", Obj.Price);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
    }
}
