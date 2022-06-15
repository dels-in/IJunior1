namespace IJunior1;

public class Task8
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько человек в очереди?");
        int grannyNumber = Int32.Parse(Console.ReadLine());
        int grannyTime = 10;
        int queueHour = (grannyNumber * grannyTime)/60;
        int queueMinute = (int)Math.Round(((double)grannyNumber * (double)grannyTime / 60 - queueHour)*60);
        Console.WriteLine($"Вам нужно отстоять {queueHour} часа(ов) {queueMinute} минут(ы).");
    }
}