using System;
using System.Collections.Generic;
using System.Text;

public class PasienAnak : Pasien
{
    public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }
    public void Menangis()
    {
        Console.WriteLine($"{nama} sedang menangis.");
    }
    public override void Aktivitas()
    {
        Console.WriteLine($"{nama} sedang dibujuk ibunya untuk minum obat.");
    }
}

