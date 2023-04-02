using tpmodul7_kelompok_8;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213039 rasyid = new DataMahasiswa_1302213039();
        rasyid.ReadJSON();

        KuliahMahasiswa_1302213039 rasyod = new KuliahMahasiswa_1302213039();
        rasyod.ReadJSON();
    }
}