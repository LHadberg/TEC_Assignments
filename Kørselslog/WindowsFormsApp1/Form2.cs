using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlDataAdapter dataAdapter;
        string connectionString;
        SqlConnection cnn;
        public Form2()
        {
            InitializeComponent();
            UpdateTable();
        }
        private void søgNavn_txtbox_TextChanged(object sender, EventArgs e)
        {
            cnnOpen();
            //Her benyttes Like operatoren til at finde et stykke tekst der ligner indholdet i '% %'(OR).
            dataGridView1.DataSource = SelectSomething
            ("SELECT *" +
            " FROM MainTabel" +
            " WHERE MainTabel.FuldeNavn" +
            " LIKE '%" + søgNavn_txtbox.Text + "%'" +
            " OR MainTabel.Nummerplade" +
            " LIKE '%" + søgNavn_txtbox.Text + "%'" +
            " OR MainTabel.Dato" +
            " LIKE '%" + søgNavn_txtbox.Text + "%'");
            cnn.Close();
        } 
        DataTable SelectSomething(string sql)
        {
            //Denne metode bruges til at selecte fra databasen vha. cnn (vores connectionstring). Denne informations returneres til databellen vi søger i ovenfor. 
            DataTable dtbl = new DataTable();
            try
            {
                dataAdapter = new SqlDataAdapter(sql, cnn);
                dataAdapter.Fill(dtbl);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtbl;
        }
        void cnnOpen()
        {
            //Denne metode åbner forbindelsen til SQL serveren. Denne er en void, så vi kan kalde på metoden når vi skal.
            connectionString = @"Data Source=10.0.4.110;Initial Catalog=Kørselslogbog;User ID=sa;Password=Passw0rd";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Denne kode åbner hovedmenuen op igen samtidig med at den gemmer det gamle. 
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        }
        private void deleteRow_Click(object sender, EventArgs e)
        {
            //Her skrives værdierne i datatabellerne i en given række til en række variabler. 
            string selectedFuldeNavn = dataGridView1.CurrentRow.Cells["FuldeNavn"].Value.ToString();
            string selectedNummerplade = dataGridView1.CurrentRow.Cells["Nummerplade"].Value.ToString();
            string selectedKm = dataGridView1.CurrentRow.Cells["Km"].Value.ToString();
            string selectedDato = dataGridView1.CurrentRow.Cells["Dato"].Value.ToString();
            cnnOpen();
            //Informationen fra ovenstående variabler bliver slettet vha. en sql command.
            SqlCommand deleteRow = new SqlCommand("DELETE from MainTabel where FuldeNavn = '"+ selectedFuldeNavn + "' AND Nummerplade = '"+ selectedNummerplade + "' AND" +
                                                  " Km = '"+ selectedKm + "' AND Dato = '"+ selectedDato + "'", cnn );
            deleteRow.ExecuteReader();
            MessageBox.Show("Entry has been deleted successfully");
            UpdateTable();
            cnn.Close();
        }
        void UpdateTable()
        {
            //Denne metode henter den nuværende information i datatabellen. Dette kan bruges til at "opdatere" informationen brugeren ser.
            cnnOpen();
            dataGridView1.DataSource = SelectSomething("SELECT *" + " FROM MainTabel");
            cnn.Close();
        }
    }
}