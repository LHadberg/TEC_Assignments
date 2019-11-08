using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace TT_DriveBook.DataService
{
    class _dataIO
    {
        DataGrid dataGrid_prt_Users;
        DataGrid dataGrid_prt_DriveLog;
        public DataGrid DataGrid_prt_Users { get => dataGrid_prt_Users; set => dataGrid_prt_Users = value; }
        public DataGrid DataGrid_prt_DriveLog { get => dataGrid_prt_DriveLog; set => dataGrid_prt_DriveLog = value; }
        // indsæt data i de 2 views
        public void PopulateGridDataView_Users()
        {
            SqlCommand command;
            SqlDataReader dataReader;
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Select BID, Navn, NrPlade, Dato, IsNull((select SUM(KilometerAntal) from dbo.DriveLog Dl where Dl.BID=Br.BID),0) AS KmTotal from dbo.Bruger Br order by Dato";
            //MessageBox.Show("sql = "+ sql);
            SqlConnection connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                var items = new List<_brugerView>();
                while (dataReader.Read())
                {
                   items.Add(new _brugerView(dataReader.GetInt32(0), 
                                              dataReader.GetString(1).Trim(),
                                              dataReader.GetString(2).Trim(),
                                              dataReader.GetDateTime(3).ToShortDateString(),
                                              dataReader.GetInt32(4)));
                } // end while
                dataReader.Close();
                command.Dispose();
                connection.Close();

                PopulateView(items);
            } // end try
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void PopulateView(List<_brugerView> items)
        {
            DataGridView dataGridView = PropertiesCL.dataGridView_Users;
            dataGridView.Columns.Clear();
            dataGridView.DataSource = items;
            dataGridView.Columns["BID"].Visible = false;
            dataGridView.Columns["Navn"].Width = 120;
            dataGridView.Columns["NrPlade"].Width = 60;
            dataGridView.Columns["Dato"].Width = 70;
            dataGridView.Columns["DrivedKm"].Width = 70;
            // edit user info => show dialog
            DataGridViewButtonColumn editInfo = new DataGridViewButtonColumn();
            editInfo.Name = "Edit_user";
            editInfo.Text = "Edit";
            editInfo.Width = 60;
            editInfo.UseColumnTextForButtonValue = true;
            int columnIndex = 5;
            dataGridView.Columns.Insert(columnIndex, editInfo);
            // add log entry  => show dialog
            DataGridViewButtonColumn addLogEntry = new DataGridViewButtonColumn();
            addLogEntry.Name = "Add_log";
            addLogEntry.Text = "Ny log";
            addLogEntry.Width = 60;
            addLogEntry.UseColumnTextForButtonValue = true;
            columnIndex = 6;
            dataGridView.Columns.Insert(columnIndex, addLogEntry);
            // delete button  => show dialog
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete_user";
            deleteButton.Text = "Delete";
            deleteButton.Width = 70;
            deleteButton.UseColumnTextForButtonValue = true;
            columnIndex = 7;
            dataGridView.Columns.Insert(columnIndex, deleteButton);


        }
        public string[] GetBrugerInfo(int BID)
        {
            //MessageBox.Show("get info BID="+BID);
            string[] BrugerInfo = new String[4];
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Select Navn, NrPlade, TotalKm, Dato from dbo.Bruger where BID='" + BID + "';";
            SqlConnection connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                BrugerInfo[0] = dataReader.GetString(0).Trim();
                BrugerInfo[1] = dataReader.GetString(1).Trim();
                BrugerInfo[2] = dataReader.GetInt32(2).ToString();
                BrugerInfo[3] = dataReader.GetDateTime(3).ToString();
                return BrugerInfo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return BrugerInfo;
            }

        }
        public void Insert_Record(string Navn, string NrPlade, string myDate)
        {
            SqlCommand command;
            //DateTime CurrDate = new DateTime();
            string CurrDate = DateTime.ParseExact(myDate, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Insert Into dbo.Bruger (Navn, NrPlade, TotalKm, Dato) Values('" + Navn + "','" + NrPlade + "','0','" + CurrDate + "')";
            SqlConnection Connection = new SqlConnection(connetionString);
            try
            {
                //MessageBox.Show("Insert new user");
                Connection.Open();
                command = new SqlCommand(sql, Connection);
                command.ExecuteNonQuery();
                command.Dispose();
                Connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Can not open connection ! error = " + ex.Message); }
        }
        public void UpdateBruger(int BID, string myDate, string Navn, string NrPlade, string DrivedKm )
        {
            SqlCommand command;
            
            string iDate = myDate.Substring(0, 10);
            string[] datoArr = iDate.Split('-');
            string dato = datoArr[2] + "-" + datoArr[1] + "-" + datoArr[0];
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Update dbo.Bruger SET Navn='" + Navn + "', NrPlade='" + NrPlade + "', Dato='" + dato + "', TotalKm='"+ DrivedKm +"' where BID='"+BID+"';";
            SqlConnection Connection = new SqlConnection(connetionString);
            try
            {
                //MessageBox.Show("Insert new user");
                Connection.Open();
                command = new SqlCommand(sql, Connection);
                command.ExecuteNonQuery();
                command.Dispose();
                Connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Can not open connection ! error = " + ex.Message); }
        }
        public void PopulateGridDataView_DriveLog(int BID)
        {
            SqlCommand command;
            SqlDataReader dataReader;
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Select Dato, Opgave, KilometerAntal from dbo.DriveLog where BID='"+BID+ "' order by Dato;";
            //MessageBox.Show("sql = "+ sql);
            SqlConnection connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                var items = new List<_logView>();
                while (dataReader.Read())
                {
                    items.Add(new _logView(dataReader.GetDateTime(0).ToShortDateString(), 
                                           dataReader.GetString(1).Trim(),
                                            dataReader.GetInt32(2)));
                } // end while
                dataReader.Close();
                command.Dispose();
                connection.Close();

                PopulateLogView(items);
            } // end try
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void PopulateLogView(List<_logView> items)
        {
            DataGridView dataGridView = PropertiesCL.dataGridView_DriveLog;
            dataGridView.Columns.Clear();
            dataGridView.DataSource = items;
            dataGridView.Columns["Dato"].Width = 70;
            dataGridView.Columns["Opgave"].Width = 160;
            dataGridView.Columns["Km_kørt"].Width = 50;
        }
        public void Insert_Log_Record(int BID, string KM_Logging, string Opgave_Logging, string Dato_Logging)
        {
            SqlCommand command;
            //MessageBox.Show("Dato_Logging = "+ Dato_Logging);
            //DateTime CurrDate = new DateTime();
            //string CurrDate = DateTime.ParseExact(Dato_Logging, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Insert Into dbo.DriveLog (BID, Dato, Opgave, KilometerAntal) Values('" + BID + "','" + Dato_Logging + "','"+ Opgave_Logging + "','" + KM_Logging + "')";
            SqlConnection Connection = new SqlConnection(connetionString);
            try
            {
                //MessageBox.Show("Insert new Log record");
                Connection.Open();
                command = new SqlCommand(sql, Connection);
                command.ExecuteNonQuery();
                command.Dispose();
                Connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Can not open connection ! error = " + ex.Message); }
        }
        public void DeleteUser(int BID)
        {
            SqlCommand command;
            string connetionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string sql = "Delete from dbo.Bruger where BID='" + BID + "';";
            SqlConnection Connection = new SqlConnection(connetionString);
            try
            {
                MessageBox.Show("Delete a user");
                Connection.Open();
                command = new SqlCommand(sql, Connection);
                command.ExecuteNonQuery();
                command.Dispose();
                Connection.Close();
                DataGridView dataGridView = PropertiesCL.dataGridView_DriveLog;
                dataGridView.Columns.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Can not open connection ! error = " + ex.Message); }
        }
    }
}