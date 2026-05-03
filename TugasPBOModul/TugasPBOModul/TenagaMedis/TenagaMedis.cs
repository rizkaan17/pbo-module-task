using System;
using System.Collections.Generic;
using System.Text;

    public class TenagaMedis : Orang
    {
        public string spesialis { get; set; }

        public TenagaMedis(string nama, int umur, string spesialis) : base(nama, umur)
        {
            this.spesialis = spesialis;
        }

        public void CekSpesialis()
        {
            Console.WriteLine($"{nama} adalah spesialis {spesialis}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang menangani pasien.");
        }
    }