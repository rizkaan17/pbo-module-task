using System;
using System.Collections.Generic;
using System.Text;

    public class Pasien : Orang
    {
        public string keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            this.keluhan = keluhan;
        }

        public void CekKeluhan()
        {
            Console.WriteLine($"{nama} sedang dirawat di rumah sakit dengan keluhan: {keluhan}");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang menunggu antrean dokter.");
        }
    }
