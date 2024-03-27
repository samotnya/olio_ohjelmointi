using Harjoitus3_Kiuas;

internal class Program
{
    private static void Main(string[] args)
    {
        // Luodaan Kiuas-olio
        Kiuas kiuas = new Kiuas();

        
        kiuas.KytkePäälle();
        kiuas.AsetaLämpötila(80);
        kiuas.AsetaKosteus(70);
        kiuas.KytkePoisPäältä();
    }
}