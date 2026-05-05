RumahSakit rs = new RumahSakit();

Dokter d1 = new Dokter("Dr. Tirta", 37, "Pediatri");
Perawat pr1 = new Perawat("Laili", 28, "Perawatan Rawat Inap");
PasienAnak pa1 = new PasienAnak("Rossa", 5, "Flu");
PasienDewasa pd1 = new PasienDewasa("Mark", 40, "Sakit Dada");
TenagaMedis tm1 = new TenagaMedis("Kevin", 35, "UGD");
Pasien p = new Pasien("Gabriela", 18, "Sakit Kepala");

rs.TambahOrang(d1);
rs.TambahOrang(pr1);
rs.TambahOrang(pa1);
rs.TambahOrang(pd1);

rs.DaftarOrang();
Console.WriteLine();
Console.WriteLine("===== AKTIVITAS ======");
tm1.Aktivitas();
p.Aktivitas();
pd1.Aktivitas();
pa1.Aktivitas();
d1.Aktivitas();
Console.WriteLine();
Console.WriteLine("===== METHOD ======");
tm1.CekSpesialis();
d1.Diagnosa();
pa1.Menangis();
pd1.Konsultasi();
p.CekKeluhan();
pr1.CekPasien();
