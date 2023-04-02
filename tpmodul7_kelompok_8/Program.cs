using tpmodul7_kelompok_8;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210130 nagif = new DataMahasiswa_1302210130("\"C:\\\\Users\\\\USER\\\\OneDrive\\\\Documents\\\\Code\\\\C#\\\\tpmodul7_kelompok_8\\\\tp7_1_1302210130.json\"");
        nagif.ReadJSON();
    }
}