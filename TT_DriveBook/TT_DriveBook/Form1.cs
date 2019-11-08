using System;
using System.Windows.Forms;
using TT_DriveBook.DataService;

namespace TT_DriveBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            PropertiesCL.dataGridView_Users = dataGridView_Users;
            PropertiesCL.dataGridView_DriveLog = dataGridView_DriveLog;
            PropertiesCL.currLogUser = currLogUser;
            _dataIO mydataIO = PropertiesCL.dataIO;
            mydataIO.PopulateGridDataView_Users();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            Form createUserDlg = new Userform_Create();
            createUserDlg.ShowDialog();
        }

        private void dataGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //MessageBox.Show("Column nr "+ e.ColumnIndex+" clicked");
                object BID = dataGridView_Users.Rows[e.RowIndex].Cells[0].Value;
                object Navn = dataGridView_Users.Rows[e.RowIndex].Cells[1].Value;
                switch (e.ColumnIndex)
                {
                    case 5:
                        {
                            // edit user
                            Form dialog = new UserForm_Edit((int)BID);
                            dialog.ShowDialog();
                        };
                        break;
                    case 6:
                        {
                            // add log
                            Form dialog = new DriverLog((int)BID, (string)Navn);
                            dialog.ShowDialog();
                        };
                        break;
                    case 7:
                        {
                            //Delete user
                            Form dialog = new Delete_User((int)BID, (string)Navn);
                            dialog.ShowDialog();

                        };
                        break;
                    default:
                        {
                        }
                        break;
                }
            }
        }
        private void dataGridView_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int BID = int.Parse(dataGridView_Users.Rows[e.RowIndex].Cells[0].Value.ToString());
            object Navn = dataGridView_Users.Rows[e.RowIndex].Cells[1].Value;
            _dataIO mydataIO = PropertiesCL.dataIO;
            mydataIO.PopulateGridDataView_DriveLog(BID);
            Label currLogUser = PropertiesCL.currLogUser;
            currLogUser.Text = (string)Navn;
        }
    }
}
