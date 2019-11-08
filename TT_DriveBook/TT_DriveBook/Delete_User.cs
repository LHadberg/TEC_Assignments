using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT_DriveBook.DataService;

namespace TT_DriveBook
{
    public partial class Delete_User : Form
    {
        public Delete_User(int bid, string navn)
        {
            InitializeComponent();
            // Populate navn
            BID.Text = bid.ToString();
            Username.Text = navn;            
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_delete_User_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            this.DialogResult = DialogResult.OK;
        }

        private void Ok_Delete_user_Click(object sender, EventArgs e)
        {
            _dataIO mydataIO = PropertiesCL.dataIO;
            mydataIO.DeleteUser(int.Parse(BID.Text.ToString()));
            mydataIO.PopulateGridDataView_Users();            
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
