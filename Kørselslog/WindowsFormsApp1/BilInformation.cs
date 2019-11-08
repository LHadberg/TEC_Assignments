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
    public partial class BilInformation : Form
    {
        string Sql = "select BilTabel.Nummerplade from BilTabel";
        SqlConnection cnn = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd");
        SqlDataAdapter dataAdapter;
        public BilInformation()
        {
            InitializeComponent();
            SletLauncher();
            RedigerLauncher();
        }
        private void BilInfo_TextChanged(object sender, EventArgs e)
        {        }
        private void Tilføj_Click(object sender, EventArgs e)
        {
            bool Check1 = string.IsNullOrEmpty(BilInfo.Text);
            //Ved hjælp at en SqlCommand insættes brugerinputtet som string i datatabellen. Hvis tekstboksen er tom udskrives en fejlmeddelelse.
            if (Check1 != true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd"))
                {
                    string query = "INSERT INTO dbo.BilTabel (Nummerplade) VALUES (@Nummerplade)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nummerplade", BilInfo.Text);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Du har tilføjet en nummerplade korrekt.");
            }
            else
            {
                MessageBox.Show("Ugyldigt input");
            }
        }
        private void TilbageTilMenu_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
        }
        private void DropDownRediger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DropDownSlet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SletLauncher()
        {
            //Dette er en dropdown menu der gør det muligt at vælge et entry i en tabel.
            string columns;

            cnn.Open();
            SqlCommand cmd = new SqlCommand(Sql, cnn);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                columns = dataReader["Nummerplade"].ToString();
                DropDownSlet.Items.Add(columns);
            }
        }
        private void Slet_Click(object sender, EventArgs e)
        {
            //Herefter slettes det valgte entry i tabellen.
            SqlConnection cnn;
            string connectionString;
            connectionString = @"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand deleteRow = new SqlCommand("DELETE from BilTabel where Nummerplade = '" + DropDownSlet.Text + "'", cnn);
            deleteRow.ExecuteReader();
            MessageBox.Show("Entry has been deleted successfully");
            cnn.Close();
        }
        public void RedigerLauncher()
        {
            //Dette er dropdownmenuen til 'Rediger' knappen.
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
                DropDownRediger.Items.Add(columns);
            }
        }
        private void Rediger_Click(object sender, EventArgs e)
        {

            bool Check1 = string.IsNullOrEmpty(RedigerInput.Text);
            if (Check1 != true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd"))
                {
                    /*For at redigere i et entry indsætter vi værdien fra brugerinputtet i den givne tabel ved hjælp af SET.
                    Dette gøres både i MainTabellen og Biltabellen.*/
                    String BilTabelUpdate = "UPDATE dbo.BilTabel SET Nummerplade = (@Nummerplade) WHERE Nummerplade = (@Rediger)";
                    String MainTabelUpdate = "UPDATE dbo.MainTabel SET Nummerplade = (@Nummerplade) WHERE Nummerplade = (@Rediger)";
                    using (SqlCommand command = new SqlCommand(BilTabelUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@Rediger", DropDownRediger.Text);
                        command.Parameters.AddWithValue("@Nummerplade", RedigerInput.Text);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(MainTabelUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@Rediger", DropDownRediger.Text);
                        command.Parameters.AddWithValue("@Nummerplade", RedigerInput.Text);
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Du har Redigeret en bil.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ugyldigt input");
            }
        }
        private void RedigerInput_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable SelectSomething(string sql)
        {
            //Denne metode bruges til at selecte fra databasen vha. cnn (vores connectionstring). Denne informations returneres til databellen vi søger i ovenfor. 
            DataTable dtbl = new DataTable();
            try
            {
                dataAdapter = new SqlDataAdapter(sql, cnn);
                dataAdapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtbl;
        }
    }
}