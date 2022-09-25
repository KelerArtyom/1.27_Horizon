public class Mainclass
{
    public static void Main()
    {
        double S, h;
        Console.WriteLine("Введите высоту:");
        h = int.Parse(Console.ReadLine());
        S = Math.Sqrt(Math.Pow(6350 + h, 2) - 40322500);
        Console.WriteLine("Расстояние до горизонта равно {0}", S);
    }

}