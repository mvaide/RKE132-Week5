//math >= 90 or chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Please enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your chemistry result:");
biology = Int32.Parse(Console.ReadLine());


if ((math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90) || (math >= 90 && chemistry >= 90))
{
    Console.WriteLine("Grats your in!");
}
else
{
    Console.WriteLine("Sorry pal, you're not in.");
}