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
    public partial class TilfoejMedarbejder : Form
    {
        public TilfoejMedarbejder()
        {
            InitializeComponent();
            RedigerLauncher();
            SletLauncher();
            Location = new Point(0, 0);
        }
        private void TilfoejMedarbejder_Load(object sender, EventArgs e)
        {        }
        private void MedarbejderInfo_TextChanged(object sender, EventArgs e)
        {        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool Check1 = string.IsNullOrEmpty(MedarbejderInfo.Text);
            if (Check1 != true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd"))
                {
                    //En SQL command tilføjer en person til personaletabellen i stringform. Hvis tekstfeltet er tomt(null) udskrives en fejlmeddelelse.
                    String query = "INSERT INTO dbo.PersonaleTabel (FuldeNavn) VALUES (@FuldeNavn)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FuldeNavn", MedarbejderInfo.Text);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Du har tilføjet en medarbejder.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ugyldigt input");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
        }
        private void DropDownRediger_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void RedigerKnap_Click(object sender, EventArgs e)
        {
            bool Check1 = string.IsNullOrEmpty(RedigerInput.Text);
            if (Check1 != true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd"))
                {
                    /*For at redigere i et entry indsætter vi værdien fra brugerinputtet i den givne tabel ved hjælp af SET.
Dette gøres både i MainTabellen og Personaletabellen.*/
                    String PersonaleTabelUpdate = "UPDATE dbo.PersonaleTabel SET FuldeNavn = (@FuldeNavn) WHERE FuldeNavn = (@Rediger)";
                    String MainTabelUpdate = "UPDATE dbo.MainTabel SET FuldeNavn = (@FuldeNavn) WHERE FuldeNavn = (@Rediger)";
                    using (SqlCommand command = new SqlCommand(PersonaleTabelUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@Rediger", DropDownRediger.Text);
                        command.Parameters.AddWithValue("@FuldeNavn", RedigerInput.Text);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(MainTabelUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@Rediger", DropDownRediger.Text);
                        command.Parameters.AddWithValue("@FuldeNavn", RedigerInput.Text);
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Du har Redigeret en medarbejder.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ugyldigt input");
            }
        }
        public void RedigerLauncher()
        {
            string columns = "";
            string Sql = "select PersonaleTabel.FuldeNavn from PersonaleTabel";
            SqlConnection conn = new SqlConnection(@"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd");
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                columns = dataReader["FuldeNavn"].ToString();
                DropDownRediger.Items.Add(columns);
            }
        }
        private void DropDownSlet_SelectedIndexChanged(object sender, EventArgs e)
        {       }
        public void SletLauncher()
        {
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
                DropDownSlet.Items.Add(columns);
            }
        }
        private void SletKnap_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString;
            connectionString = @"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand deleteRow = new SqlCommand("DELETE from PersonaleTabel where FuldeNavn = '" + DropDownSlet.Text + "'", cnn);
            deleteRow.ExecuteReader();
            MessageBox.Show("Entry has been deleted successfully");
            cnn.Close();
        }
        private void RedigerInput_TextChanged(object sender, EventArgs e)
        {        }
    }
}
