using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using TT_DriveBook.DataService;

namespace TT_DriveBook
{
    public partial class UserForm_Edit : Form
    {
        public UserForm_Edit(int bid)
        {
            InitializeComponent();
            // Populate fields
            _dataIO mydataIO = PropertiesCL.dataIO;
            string[] BrugerInfo = mydataIO.GetBrugerInfo(bid);
            //Navn, NrPlade, TotalKm, Dato
            BID.Text = bid.ToString();
            Navn.Text = BrugerInfo[0];
            NrPlade.Text = BrugerInfo[1];
            DrivedKm.Text = BrugerInfo[2];
            PDato.Text = BrugerInfo[3];
        }
        private void UserForm_Edit_Load(object sender, EventArgs e)
        {
        }

        private void Save_Changes_User_Click(object sender, EventArgs e)
        {
            _dataIO mydataIO = PropertiesCL.dataIO;
            //MessageBox.Show("BID = " + BID.Text.ToString() + " Navn = " + Navn.Text.ToString() + " Nummer Plade = " + NrPlade.Text.ToString() + " Km = " + DrivedKm.Text.ToString());
            mydataIO.UpdateBruger(int.Parse(BID.Text.ToString()), PDato.Text.ToString(),Navn.Text.ToString(), NrPlade.Text.ToString(), DrivedKm.Text.ToString());
            mydataIO.PopulateGridDataView_Users();
            BID.Text = "0";
            Navn.Text = "";
            NrPlade.Text = "";
            DrivedKm.Text = "0";
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            BID.Text = "0";
            Navn.Text = "";
            NrPlade.Text = "";
            DrivedKm.Text = "0";

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
