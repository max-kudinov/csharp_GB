int number;
do
{
    Console.WriteLine("Enter a 5 digit number");
    number = Convert.ToInt32(Console.ReadLine());
} while (number > 99999 || number < 10000);

bool isPalindrome(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
        return true;
    return false;
}

Console.WriteLine(isPalindrome(number));
