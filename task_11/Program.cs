int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"The random number is {rndNum}");

int hundrends = rndNum / 100;
int ones = rndNum % 10;

int newNum = hundrends * 10 + ones;

Console.WriteLine($"New number without second digit is {newNum}");
