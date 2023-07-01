using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace GorselProgramlamaOdev
{
    class veritabani
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oem\Desktop\UNI\GorselProgramlamaOdev.accdb");
       
        public List<Hotel> Liste()
        {
            List<Hotel> hotels = new List<Hotel>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Oteller", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Hotel k = new Hotel();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.OTEL_ADI = dr[1].ToString();
                k.Adres = dr[2].ToString();

                hotels.Add(k);
            }
            baglanti.Close();
            return hotels;
        }
        

    }
}
