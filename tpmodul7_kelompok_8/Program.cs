using tpmodul7_kelompok_8;
internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210124 ryan = new DataMahasiswa1302210124();
        ryan.ReadJSON();

        Console.WriteLine("\n=======================================\n");

        KuliahMahasiswa1302210124 Kuliahryan = new KuliahMahasiswa1302210124();
        Kuliahryan.ReadJSON();
    }
}