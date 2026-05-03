using System;
using System.Collections.Generic;
using System.Text;

public class Perawat : TenagaMedis
{
    public Perawat(string nama, int umur, string spesialis) : base(nama, umur, spesialis) { }

    public void CekPasien()
    {
        Console.WriteLine($"Dokter {nama} sedang memeriksa pasien.");
    }
    public override void Aktivitas()
    {
        Console.WriteLine($"Dokter {nama} sedang bekerja di rumah sakit.");
    }
}
