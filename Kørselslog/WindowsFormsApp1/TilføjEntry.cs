using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TilføjEntry : Form
    {
        public TilføjEntry()
        {
            InitializeComponent();
            DropDownNavnLauncher();
            DropDownPladeLauncher();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
        }
        private void Tilføjkørsel_Click(object sender, EventArgs e)
        {
            string Navn, Plade, SDato, SKM;
            Navn = DropDownNavn.Text;
            Plade = DropDownPlade.Text;
            SKM = KM.Text;
            SDato = DatoVaelger.Text;
            bool Check1 = string.IsNullOrEmpty(Navn);
            bool Check2 = string.IsNullOrEmpty(Plade);
            bool Check3 = string.IsNullOrEmpty(SKM);
            bool Check4 = string.IsNullOrEmpty(SDato);
            if (IsNumeric(KM.Text) == true)
            {
                //Før der tilføjes et nyt entry til tabellen checker checker vi at der er en værdi i hvert felt. Hvis ikke vil der blive udskrevet en fejlmeddelelse i stedet.
                if (Check1 != true && Check2 != true && Check3 != true && Check4 != true)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd"))
                    {
                        String query = "INSERT INTO dbo.MainTabel (FuldeNavn,Nummerplade,Km,Dato) VALUES (@Navn,@Plade,@Km, @Dato)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Navn", DropDownNavn.Text);
                            command.Parameters.AddWithValue("@Plade", DropDownPlade.Text);
                            command.Parameters.AddWithValue("@Km", KM.Text);
                            command.Parameters.AddWithValue("@Dato", DatoVaelger.Text);
                            connection.Open();
                            int result = command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Tilføjede Kørsel.");
                }
            }
            else
            {
                MessageBox.Show("Et eller flere felter blev ikke udfyldt korrekt.");
            }
        }
        private void KM_TextChanged(object sender, EventArgs e)
        {        }
        private void DropDownNavn2_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void DropDownPlade_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        public void DropDownNavnLauncher()
        {
            //Dropdown menu til Navnetabellen. 
            string columns = "";
            string Sql = "select PersonaleTabel.FuldeNavn from PersonaleTabel";
            SqlConnection conn = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR;
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                columns = DR["FuldeNavn"].ToString();
                DropDownNavn.Items.Add(columns);
            }
        }
        public void DropDownPladeLauncher()
        {
            //Dropdown menu til Biltabellen.
            string columns = "";
            string Sql = "select BilTabel.Nummerplade from BilTabel";
            SqlConnection conn = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR;
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                columns = DR["Nummerplade"].ToString();
                DropDownPlade.Items.Add(columns);
            }
        }
        private void DatoVaelger_ValueChanged(object sender, EventArgs e)
        {       }
        public static bool IsNumeric(object Expression)
        {
            //Denne metode checker hvorom den indtastede værdi er numerisk.
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}