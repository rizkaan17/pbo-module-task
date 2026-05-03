using System;
using System.Collections.Generic;
using System.Text;

    public class RumahSakit
    {
        public List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
        }

        public void DaftarOrang()
        {
        Console.WriteLine("===== DAFTAR ORANG DI RUMAH SAKIT =====");
        foreach (var o in daftarOrang)
        {
            o.InfoOrang();
            Console.WriteLine("--------------------------");
        }
    }
}
