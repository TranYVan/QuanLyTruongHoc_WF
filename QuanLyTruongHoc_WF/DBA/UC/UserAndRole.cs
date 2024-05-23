using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc_WF.DBA.UC
{
    public partial class UserAndRole : UserControl
    {
        private OracleConnection con;
        public static DataGridView grid1;
        public static DataGridView grid2;

        public UserAndRole()
        {
            InitializeComponent();
            con = Login.con;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Select table
                string selectTableSql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS ORDER BY USERNAME";
                OracleCommand command = new OracleCommand(selectTableSql, con);
                command.BindByName = true;
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                userGrid.DataSource = dataTable;
                grid1 = userGrid;

                // Select View
                string selectViewSql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                OracleCommand command1 = new OracleCommand(selectViewSql, con);
                command1.BindByName = true;
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                roleGrid.DataSource = dataTable1;
                grid2 = roleGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserAndRole_Load(object sender, EventArgs e)
        {

        }
    }
}
