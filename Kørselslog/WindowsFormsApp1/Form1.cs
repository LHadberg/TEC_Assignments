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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Åbner en ny form.
            var frm = new Form2();
            frm.Location = this.Location;
            //Gemmer det nuværende vindues placering og åbner det nye vindue dér.
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new TilfoejMedarbejder();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new BilInformation();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new TilføjEntry();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }
    }
}