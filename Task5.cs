namespace IJunior1;

public class Task5
{
    static void Main(string[] args)
    {
        string lastName = "Влад";
        string firstName = "Черненко";
        string mezhdyName = firstName;
        
        firstName = lastName;
        lastName = mezhdyName;
        Console.WriteLine($"Ваше имя: {firstName}. Ваша фамилия: {lastName}");
        


    }
}