namespace IJunior1;

public class Task6
{
    static void Main(string[] args)
    {
        double row = 3;
        double images = 52;
        
        int fullRows = (int) (images / row);
        int remainedImages = (int)Math.Round(((images/row - fullRows) * row));
        
        Console.WriteLine($"Количество полностью заполненных рядов: {fullRows}." +
                          $"Количество оставшихся картинок: {remainedImages}");
    }
}