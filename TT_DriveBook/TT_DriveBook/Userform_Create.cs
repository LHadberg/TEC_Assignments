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
    public partial class Userform_Create : Form
    {
        public Userform_Create()
        {
            InitializeComponent();
        }

        private void Userform_Create_Load(object sender, EventArgs e)
        {
            // populate fields with data
            _dataIO mydataIO = PropertiesCL.dataIO;
            CurrDato.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Add_New_User_Click(object sender, EventArgs e)
        {
            _dataIO mydataIO = PropertiesCL.dataIO;
            //MessageBox.Show("BID = " + BID.Text.ToString()+" Navn = " +Navn.Text.ToString()+" Nummer Plade = "+NrPlade.Text.ToString() + " Km = "+ DrivedKm+" - close dialog");
            mydataIO.Insert_Record(Navn.Text.ToString().Trim(), NrPlade.Text.ToString().Trim(), CurrDato.Text.ToString());
            mydataIO.PopulateGridDataView_Users();
            BID.Text = "0";
            Navn.Text = "";
            NrPlade.Text = "";
            DrivedKm.Text = "0";
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_New_User_Click(object sender, EventArgs e)
        {
            BID.Text = "0";
            Navn.Text = "";
            NrPlade.Text = "";
            DrivedKm.Text = "0";
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
