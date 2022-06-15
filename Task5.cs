namespace IJunior1;

public class Task5
{
    static void Main(string[] args)
    {
        string lastName = "Влад";
        string firstName = "Черненко";
        string buffer = firstName;
        
        firstName = lastName;
        lastName = buffer;
        Console.WriteLine($"Ваше имя: {firstName}. Ваша фамилия: {lastName}");
    }
}
