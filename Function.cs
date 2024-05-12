using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Danhmuchanghoa
{
    internal class Function
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void ketnoi()
        {
            connstring = "Data Source=MINHMINHXINHGAI\\MINH;Initial Catalog=Quanlyhanghoa;Integrated Security=True";
            conn = new SqlConnection(connstring);
            conn.ConnectionString = connstring;
            conn.Open();
           // MessageBox.Show("Ket noi thanh cong");
        }
        public static void closeconnection(SqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public static DataTable GetDatatoTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand();
            mydata.SelectCommand.Connection = Function.conn;
            mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Function.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Function.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Function.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }

}