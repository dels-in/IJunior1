namespace IJunior1;

public class Task4
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Введите Ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Введите Ваш возраст: ");
        string age= Console.ReadLine();
        Console.WriteLine($"Введите Ваш рост:");
        string height= Console.ReadLine();
        Console.WriteLine($"Введите Ваш вес: ");
        string weight = Console.ReadLine();
        
        Console.WriteLine($"Вас зовут {name}. Ваш возраст{age}. Ваш рост {height}. Ваш вес {weight}");
    }
}