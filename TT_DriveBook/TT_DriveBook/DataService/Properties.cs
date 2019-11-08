using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_DriveBook.DataService
{
    class PropertiesCL
    {
        public static _dataIO dataIO;
        public static DataGridView dataGridView_Users;
        public static DataGridView dataGridView_DriveLog;
        public static Label currLogUser;
        static PropertiesCL()
        {
            dataIO = new _dataIO();
        }

    }
}
