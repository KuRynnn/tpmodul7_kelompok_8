using tpmodul7_kelompok_8;
internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210059 fadel = new DataMahasiswa1302210059();
        fadel.ReadJSON();

        Console.WriteLine("\n=======================================\n");

        KuliahMahasiswa1302210059 KuliahFadel = new KuliahMahasiswa1302210059();
        KuliahFadel.ReadJSON();
    }
}