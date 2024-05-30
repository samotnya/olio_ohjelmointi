using Harjoitus9_Radio;

internal class Program
{
    private static void Main(string[] args)
    {
       Radio radio = new Radio();

        radio.SetKytkin(true);
        radio.SetKanavaValinta();
        radio.SetAanenvoimakkuudenSaadin();
    }
}