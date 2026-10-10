Console.WriteLine("First number: ");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Second number: ");
double number2 = double.Parse(Console.ReadLine());

double sum = number1 + number2;
double difference = number1 - number2;
double product = number1 * number2;
double division = number1 / number2;

Console.WriteLine();
Console.WriteLine($"{number1} + {number2} = {sum}");
Console.WriteLine($"{number1} - {number2} = {difference}");
Console.WriteLine($"{number1} * {number2} = {product}");
Console.WriteLine($"{number1} / {number2} = {division}");

