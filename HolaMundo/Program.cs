
using System.ComponentModel.Design;
using System.Timers;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Bienvenido /(°-°)/\n");
        Console.WriteLine("********************");
        Console.WriteLine("* Conversor romano *");
        Console.WriteLine("********************\n");
        Console.WriteLine("Ingrese un numero entre 1 y 2022: ");

        int n = 0;
        n = Convert.ToInt32(Console.ReadLine());

        if (n < 1 || n > 2022)
        {
            Console.WriteLine("\n-_- El numero debe estar dentro del rango");
            Console.WriteLine("--> Precione cualquier tecla para finalizar...");
            Console.ReadKey();
            return;
        }

        string romano  = "";
        int mil   =  n / 1000;
        int cen   = (n % 1000) / 100;
        int dec   = (n % 100) / 10;
        int uni   =  n % 10;

        string[] unidadesRomanas = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] decenasRomanas  = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] centenasRomanas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] millaresRomanos = { "", "M", "MM", "MMM" };

        string unidades = unidadesRomanas[uni];
        string decenas  = decenasRomanas [dec];
        string centenas = centenasRomanas[cen];
        string miles    = millaresRomanos[mil];   

        romano = miles + centenas + decenas + unidades;
        Console.WriteLine("\nEl numero en romano es: " + romano);
        Console.WriteLine("--> Precione cualquier tecla para finalizar...");
        Console.ReadKey();

    }
}