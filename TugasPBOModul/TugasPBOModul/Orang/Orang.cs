using System;
using System.Collections.Generic;
using System.Text;

    public class Orang
    {
        public string nama {  get; set; }
        public int umur { get; set; }

        public Orang(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public virtual void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang berada di lingkungan Rumah Sakit.");
        }

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Nama: {nama}, Umur: {umur}");
        }
    }
