using System;
using System.Text.RegularExpressions;

public class Validation
{
    // Регулярний вираз для перевірки домашнього номера телефону
    private static readonly Regex homePhoneRegex = new Regex(@"^\d{10}$");

    // Регулярний вираз для перевірки номера мобільного телефону
    private static readonly Regex mobilePhoneRegex = new Regex(@"^\+?\d{10,15}$");

    // Регулярний вираз для перевірки імейлів
    private static readonly Regex emailRegex =
        new Regex(@"^[a-zA-Z0-9._%+-]{6,50}@gmail\.com$");

    // Регулярний вираз для перевірки повного імені (3 слова, від 2 до 20 символів кожне)
    private static readonly Regex fullNameRegex =
        new Regex(@"^\b(\w{2,20}\b\s?){3}$");

    // Регулярний вираз для перевірки пароля
    private static readonly Regex passwordRegex =
        new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,16}$");


    // Метод перевірки домашнього номера телефону
    public static bool ValidateHomePhone(string number)
    {
        return homePhoneRegex.IsMatch(number);
    }

    // Метод перевірки номера мобільного телефону
    public static bool ValidateMobilePhone(string number)
    {
        return mobilePhoneRegex.IsMatch(number);
    }

    // Метод перевірки email-адреси
    public static bool ValidateEmail(string email)
    {
        return emailRegex.IsMatch(email);
    }

    // Метод to validate full name
    public static bool ValidateFullName(string name)
    {
        return fullNameRegex.IsMatch(name);
    }

    // Метод перевірки пароля
    public static bool ValidatePassword(string password)
    {
        return passwordRegex.IsMatch(password);
    }

    static void Main()
    {
        // Тести
        Console.WriteLine("Home Phone Validation:");
        Console.WriteLine(ValidateHomePhone("1234567890")); // Valid
        Console.WriteLine(ValidateHomePhone("123456789"));  // Invalid

        Console.WriteLine("\nMobile Phone Validation:");
        Console.WriteLine(ValidateMobilePhone("+49175876201")); // Valid
        Console.WriteLine(ValidateMobilePhone("123456"));       // Invalid

        Console.WriteLine("Email Validation:");
        Console.WriteLine(ValidateEmail("kotao1206@gmail.com")); // Valid
        Console.WriteLine(ValidateEmail("ko@ymail.com"));      // Invalid

        Console.WriteLine("\nFull Name Validation:");
        Console.WriteLine(ValidateFullName("Sam Olegovich Ivanov"));   // Valid
        Console.WriteLine(ValidateFullName("Sam"));             // Invalid

        Console.WriteLine("\nPassword Validation:");
        Console.WriteLine(ValidatePassword("Passw0rd!"));        // Valid
        Console.WriteLine(ValidatePassword("password"));         // Invalid
    }
}
