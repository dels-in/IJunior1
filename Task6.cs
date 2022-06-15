namespace IJunior1;

public class Task6
{
    static void Main(string[] args)
    {
        int row = 3;
        int images = 52;
        
        int fullRows = images / row;
        int remainedImages = images%row;
        
        Console.WriteLine($"Количество полностью заполненных рядов: {fullRows}." +
                          $"\nКоличество оставшихся картинок: {remainedImages}");
    }
}
