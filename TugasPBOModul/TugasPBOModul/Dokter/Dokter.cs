using System;
using System.Collections.Generic;
using System.Text;

public class Dokter : TenagaMedis
{
    public Dokter(string nama, int umur, string spesialis) : base(nama, umur, spesialis) { }

    public void Diagnosa()
    {
        Console.WriteLine($"Dokter {nama} sedang mendiagnosa pasien.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"Dokter {nama} sedang bekerja di rumah sakit.");
    }
}

