﻿using System;

class Karyawan
{
    protected string Nama;
    protected string ID;
    protected double Gaji_Pokok;

    public Karyawan(string Nama, string ID, double Gaji_Pokok)
    {
        this.Nama = Nama;
        this.ID = ID;
        this.Gaji_Pokok = Gaji_Pokok;
    }

    public virtual double HitungGaji()
    {
        return Gaji_Pokok;
    }

    public void TampilkanData()
    {
        Console.WriteLine($"Nama        : {Nama}");
        Console.WriteLine($"ID          : {ID}");
        Console.WriteLine($"Gaji Akhir  : {HitungGaji()}");
        Console.WriteLine("---------------------------");
    }
}

class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gaji_pokok)
        : base(nama, id, gaji_pokok) { }

    public override double HitungGaji()
    {
        return base.HitungGaji() + 500000;
    }
}

class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return base.HitungGaji() - 200000;
    }
}

class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return base.HitungGaji();
    }
}

class Program
{
    static void Main()
    {
        Karyawan k1 = new KaryawanTetap("IU", "K001", 5000000);
        Karyawan k2 = new KaryawanKontrak("Lino", "K011", 4500000);
        Karyawan k3 = new KaryawanMagang("Zayyan", "K021", 2000000);

        Console.WriteLine("===  Data Karyawan ===");
        k1.TampilkanData();
        k2.TampilkanData();
        k3.TampilkanData();
    }
}



