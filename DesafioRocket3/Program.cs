
Console.WriteLine("digite um numero");
var number1 = Console.ReadLine();
Console.WriteLine("digite um segundo numero");
var number2 = Console.ReadLine();

double num2 = Double.Parse(number2);
double num1 = Double.Parse(number1);


 double sum()
{
    return num1 + num2;
}

double division()
{
    if(num1 != 0 && num2 != 0)
    {
        return num1 / num2;
    }else
    {
        return 0;
    }
   
}

double subtract()
{
    return num1 - num2;
}

double multiplication()
{
    return num1 * num2;
}

double average()
{
    return (num1 + num2) / 2; 
}


Console.WriteLine("a soma entre os dois numeros e: "+ sum());
Console.WriteLine("a divisao entre os dois numeros e: "+ division());
Console.WriteLine("a subtracao entre os dois numeros e: "+ subtract());
Console.WriteLine("a multiplicação entre os dois numeros e: "+ multiplication());
Console.WriteLine("a media entre os dois numeros e: " + average());