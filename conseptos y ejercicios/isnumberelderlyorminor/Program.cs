var numberString = string.Empty;
do
{
    Console.WriteLine("ingresa un numero o escriba 'salir' para salir:");
    numberString = Console.ReadLine();//esto me lo lee como un string un dato solamente
    if (numberString.ToLower() == "salir" )
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt)) //esto me lo convierte a un numero entero, si no se puede convertir me devuelve un 0
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"el numero {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"el numero {numberInt}, es impar");
        }
    }
    else
    {
        Console.WriteLine($"el numero que ingreso: {numberString}, no es un numero entero.");
    }
} while (numberString!.ToLower()!="salir");//while true hace que el programa se ejecute de manera infinitamente hasta apretar control+c
Console.WriteLine("gracias por utilizarme");