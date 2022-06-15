namespace IJunior1;

public class Task5
{
    static void Main(string[] args)
    {
        string lastName = "Влад";
        string firstName = "Черненко";
        string middleName = firstName;
        
        firstName = lastName;
        lastName = middleName;
        Console.WriteLine($"Ваше имя: {firstName}. Ваша фамилия: {lastName}");
        


    }
}
