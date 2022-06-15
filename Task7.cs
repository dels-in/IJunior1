namespace IJunior1;

public class Task7
{
    static void Main(string[] args)
    {
        int crystalCost = 45;
        Console.WriteLine($"Сегодня цена кристалла: {crystalCost}");
        
        Console.WriteLine("Введите количество имеющегося золота: ");
        int goldBefore = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите требуемое количество кристаллов: ");
        int crystalNumber = Int32.Parse(Console.ReadLine());

        int goldAfter = goldBefore - crystalCost * crystalNumber;
        Console.WriteLine($"Вы купили {crystalNumber} кристаллов. У Вас осталось {goldAfter} золота");
    }
}