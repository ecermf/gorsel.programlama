using System;
using System.Collections.Generic;
using System.Text;

namespace GorselProgramlamaOdev
{
    class Hotel
    {
        int id;
        string adres;
        string otel_adi;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public string OTEL_ADI
        {
            get { return otel_adi; }
            set { otel_adi = value; }
        }
    }
}
