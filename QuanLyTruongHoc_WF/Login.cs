using Oracle.ManagedDataAccess.Client;
using QuanLyTruongHoc_WF.DBA;
using QuanLyTruongHoc_WF.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTruongHoc_WF
{
    public partial class Login : Form
    {
        public static OracleConnection con;

        public Login()
        {
            con = new OracleConnection();
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (psw_txtbox.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (role_combox.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }
            /*string username = username_txtbox.Text;*/
            try
            {
                string connectionString = "";
                var appSettings = ConfigurationManager.AppSettings;
                string hostname = appSettings["hostname"] ?? "localhost";
                string port = appSettings["port"] ?? "1521";
                
                if (role_combox.Text == "Quản trị viên")
                {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/xe;DBA Privilege=SYSDBA; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                } else {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/xe; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                }

                MessageBox.Show(connectionString);
                con.ConnectionString = connectionString;
                con.Open();
                MessageBox.Show(connectionString);

                if (role_combox.Text == "Quản trị viên")
                {

                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connect với tư cách là quản trị viên thành công!");
                    DBA_Home dba = new DBA_Home();
                    dba.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Connect với tư cách là nhân viên thành công!");
                    Emp_Home emp_home = new Emp_Home();
                    emp_home.Show();
                    this.Hide();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
