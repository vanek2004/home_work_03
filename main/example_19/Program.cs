// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a five-digit number --> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 99999) {

    int Palindrome (int num){
        int firstDigit = num / 10000;
        int secondDigit = (num / 1000) % 10;
        int penultimateDigit = (num / 10) % 10;
        int lastDigit = num  % 10;

        int result = firstDigit == lastDigit && secondDigit == penultimateDigit ? 1 : 0;
        return result;
    }
    int palindrome = Palindrome(number);
    string result = palindrome == 1 ? "YES it's polindrome" : "NO it's not a polindrome";
    Console.WriteLine($"{result}");
    
}
else
{
    Console.WriteLine($"You entered a non-five-digit number!!!");
}