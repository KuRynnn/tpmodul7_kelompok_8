using tpmodul7_kelompok_8;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210130 nagif = new DataMahasiswa_1302210130();
        nagif.ReadJSON();

        Console.WriteLine("\n-----=============-------\n");

        KuliahMahasiswa_1302210130 figan = new KuliahMahasiswa_1302210130();
        figan.ReadJSON();
    }
}