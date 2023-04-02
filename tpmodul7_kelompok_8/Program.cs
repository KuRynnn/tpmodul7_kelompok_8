using tpmodul7_kelompok_8;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213102 fahryan = new DataMahasiswa_1302213102();
        fahryan.ReadJSON();
        KuliahMahasiswa_1302213102 matkul = new KuliahMahasiswa_1302213102();
        matkul.ReadJSON();
    }
}