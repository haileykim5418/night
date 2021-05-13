using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wholesale
{
    class DB_Wholesale
    {
        public static SqlConnection conn = new SqlConnection();

        public static void ConnectDB() //DB연결시 사용할 객체 및 함수선언
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3"
                , "local", "WHOLESALE", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static DataSet DBset(string tableName)
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM " + tableName;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            conn.Close();

            return ds;
        }

        /*public static DataSet DBset(string table, string id)
        {
            ConnectDB();

            string sqlcommand = "SELECT * FROM " + table + " WHERE ID = " + id;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlcommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            conn.Close();
            return ds;
        }*/

        public static DataSet C_DB_select() //CUSTOMER테이블 조회
        {
            ConnectDB();

            string sqlcommand = "SELECT * FROM WS_CUS_TABLE";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


            cmd.CommandText = sqlcommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WS_CUS_TABLE");



            cmd.ExecuteNonQuery();
            conn.Close();

            return ds;
        }

        public static DataSet C_DB_CUST() //CUSTOMER만 조회
        {
            ConnectDB();

            string sqlcommand = "SELECT CUSTOMER FROM WS_CUS_TABLE";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


            cmd.CommandText = sqlcommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WS_CUS_TABLE");



            cmd.ExecuteNonQuery();
            conn.Close();

            return ds;
        }
        public static DataSet DB_select() //조회
        {
            ConnectDB();

            string sqlcommand = "SELECT * FROM WS_TABLE";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


            cmd.CommandText = sqlcommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WS_TABLE");



            cmd.ExecuteNonQuery();
            conn.Close();

            return ds;
        }

        public static void DB_insert(InventoryData ivdata) //inventory에 내용을 추가하는 메소드. InventoryData정보들을 매개변수로 가지고 와서 추가
        {
            ConnectDB();

            string sqlcommand = "INSERT INTO WS_TABLE (ITEM, ID, SIZE, COLOR, STOCK) values (@item,@id,@size,@color,@stock)";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@item", ivdata.Item);
            cmd.Parameters.AddWithValue("@id", ivdata.Id);
            cmd.Parameters.AddWithValue("@size", ivdata.Size);
            cmd.Parameters.AddWithValue("@color", ivdata.Color);
            cmd.Parameters.AddWithValue("@stock", ivdata.Stock);

            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static void C_DB_insert(CustomersData cdata)
        {
            ConnectDB();

            string sqlcommand = "INSERT INTO WS_CUS_TABLE (CUSTOMER, BNUM, ADDR, PHONE, MAIL) values (@customer,@bnum,@addr,@phone,@mail)";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@customer", cdata.Customer);
            cmd.Parameters.AddWithValue("@bnum", cdata.Bnum);
            cmd.Parameters.AddWithValue("@addr", cdata.Addr);
            cmd.Parameters.AddWithValue("@phone", cdata.Phone);
            cmd.Parameters.AddWithValue("@mail", cdata.Mail);

            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DB_delete(string id)
        {

            ConnectDB();
            string sqlcommand = "DELETE FROM WS_TABLE WHERE ID = @id";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Console.WriteLine("id : " + id);
            cmd.CommandText = sqlcommand;
            if (cmd.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("delete 성공");
            }
            else
            {
                Console.WriteLine("delete 실패");
            }
            conn.Close();
        }

        public static void DB_delete_cus(string bnum)
        {

            ConnectDB();
            string sqlcommand = "DELETE FROM WS_CUS_TABLE WHERE BNUM = @bnum";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@bnum", bnum);
            Console.WriteLine("bnum : " + bnum);
            cmd.CommandText = sqlcommand;
            if (cmd.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("delete 성공");
            }
            else
            {
                Console.WriteLine("delete 실패");
            }
            conn.Close();
        }

        public static void DB_update(string item, string id, string size, string color, string stock)
        {

            ConnectDB();

            string sqlcommand = "UPDATE WS_TABLE SET ITEM=@item, ID=@id, SIZE=@size, COLOR=@color, STOCK=@stock WHERE ID=@id";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@color", color);
            cmd.Parameters.AddWithValue("@stock", stock);

            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static void C_DB_update(string customer, string bnum, string addr, string phone, string mail)
        {
            
            ConnectDB();

            string sqlcommand = "UPDATE WS_CUS_TABLE SET CUSTOMER=@customer, BNUM=@bnum, ADDR=@addr, PHONE=@phone, MAIL=@mail WHERE BNUM=@bnum";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@customer", customer);
            cmd.Parameters.AddWithValue("@bnum", bnum);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mail", mail);

            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
 
}





