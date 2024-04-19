//temp <= 0 - freezing cold
//temp > 0 and temp <= 10 - cold
//temp > 10 and temp <= 15 - chilly
//temp > 15 and temp <= 20 - warm
//temp > 20 and temp <= 30 - very warm
//temp > 30 - hot


Console.WriteLine("Enter the temperature");
int temp = Int32.Parse(Console.ReadLine());

if (temp > 30)
{
    Console.WriteLine("It's hot");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("It's very warm");
}
else if (temp > 15 && temp <= 20)
{
    Console.WriteLine("It's warm");
}
else if (temp > 10 && temp <= 15)
{
    Console.WriteLine("It's chilly");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("It's cold");
}
else if (temp <= 30)
{
    Console.WriteLine("It's freezing cold");
}
else
{
    Console.WriteLine("you didn't enter a number");
}