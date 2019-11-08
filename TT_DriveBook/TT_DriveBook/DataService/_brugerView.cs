using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_DriveBook.DataService
{
    class _brugerView
    {
        public int BID { get; set; }
        public string Navn { get; set; }
        public string NrPlade { get; set; }
        public string Dato { get; set; }
        public int DrivedKm { get; set; }

        public _brugerView(int BID, string navn, string nrplade, string dato, int drivedKm)
        {
            this.BID = BID;
            this.Navn = navn;
            this.NrPlade = nrplade;
            this.Dato = dato;
            this.DrivedKm = drivedKm;
        }

    }
}
