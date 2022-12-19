using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace CSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publicsher = "Data Source=DESKTOP-5BJLU1V;Initial Catalog=TN_CSDLPT;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String severname = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static String mSV = "";
        public static int mCoSo = 0;

        /// <> new code chuyển server

        public static String connstr1;
        public static String servername1 = "";
        public static SqlConnection conn1 = new SqlConnection();

        public static BindingSource bds_dspm = new BindingSource();

        public static int KetNoiCosoKhac()
        {
            if (Program.conn1 != null && Program.conn1.State == ConnectionState.Open)
                Program.conn1.Close();
            try
            {
                Program.connstr1 = "Data Source=" + Program.servername1 + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.remotelogin + ";password=" + Program.remotepassword;
                Program.conn1.ConnectionString = Program.connstr1;
                Program.conn1.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.severname + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.");
                return 0;
            }

        }
        public static SqlDataReader ExecSqlDataReader(string strlenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.ConnectionString = Program.connstr_publicsher;
                Program.conn.Open();
            }
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string strlenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strlenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; // 10 phút
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format cell lại cột \"Ngày \" qua kiểu Number hoặc mở file Excel.");
                else
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                return ex.State; // trạng thái lỗi gởi từ RaisError trong sql server qua
            }
        }
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
        }
    }
}
