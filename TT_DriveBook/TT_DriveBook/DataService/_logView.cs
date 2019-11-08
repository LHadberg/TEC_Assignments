namespace TT_DriveBook.DataService
{
    class _logView
    {
        public string Dato { get; set; }
        public string Opgave { get; set; }
        public int Km_kørt { get; set; }

        public _logView(string dato, string opgave, int drivedKm)
        {
            this.Dato = dato;
            this.Opgave = opgave;
            this.Km_kørt = drivedKm;
        }

    }
}