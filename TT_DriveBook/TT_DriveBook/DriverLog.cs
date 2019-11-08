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
    public partial class DriverLog : Form
    {
        public DriverLog(int bid, string userName)
        {
            InitializeComponent();
            BID_Logging.Text = bid.ToString();
            Navn_Logging.Text = userName;
            Navn.Text = userName;
        }

        private void Dato_Logging_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Opgave_Logging_TextChanged(object sender, EventArgs e)
        {

        }

        private void KM_Logging_TextChanged(object sender, EventArgs e)
        {

        }

        private string getMd(string md)
        {
            string md_nr = "0";
            string[] MDarr = new string[13] { "--", "januar", "februar", "marts", "april", "maj", "juni", "juli", "august", "september", "oktober", "november", "december" };
            for (int i = 1; i < 13; i++)
            {
                //MessageBox.Show("MDarr[i] = "+ MDarr[i]);
                if (MDarr[i] == md)
                {
                    md_nr = (i<10)?"0"+i.ToString():i.ToString();
                    break;
                }                
            }
            return md_nr;
        }
        private void Ok_Logging_Click(object sender, EventArgs e)
        {
            _dataIO mydataIO = PropertiesCL.dataIO;
            //MessageBox.Show("BID = " + BID_Logging.Text.ToString()+" KM = " + KM_Logging.Text.ToString()+" Opgave = "+ Opgave_Logging.Text.ToString() + " Dato = "+ Dato_Logging.Text.ToString());
            int BID = int.Parse(BID_Logging.Text.ToString());
            string rawDato = Dato_Logging.Value.ToString();
            string[] datoArr = rawDato.Split(' ');
            string[] datoStrArr = datoArr[0].Split('-');
            string dato = datoStrArr[2] + "-" + datoStrArr[1] + "-" + datoStrArr[0];
            mydataIO.Insert_Log_Record(BID, KM_Logging.Text.ToString().Trim(), Opgave_Logging.Text.ToString().Trim(), dato);

            BID_Logging.Text = "";
            Opgave_Logging.Text = "";
            KM_Logging.Text = "";
            Label currLogUser = PropertiesCL.currLogUser;
            currLogUser.Text = Navn_Logging.Text.ToString();
            mydataIO.PopulateGridDataView_DriveLog(BID);
            mydataIO.PopulateGridDataView_Users();
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Logging_Click(object sender, EventArgs e)
        {
            BID_Logging.Text = "";
            Opgave_Logging.Text = "";
            KM_Logging.Text = "";
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
