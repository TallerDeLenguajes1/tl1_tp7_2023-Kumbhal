// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Console.WriteLine("Hello, World!");
int operacion;
operacion = 0;
int intNum1 = 0;
bool anda;
string? numString;
void menu(){
    Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Limpiar Calculadora\n9. Salir\nElija una opcion: ");
}
Calculadora calc = new Calculadora();
while (operacion != 9){
    anda = false;
    numString = "";
    menu();
    while (!anda){
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out intNum1);
        if (!anda){
        Console.WriteLine(numString + " no válido.");
        }
    }
    operacion = intNum1;
    if(operacion == 5){
        calc.Limpiar();
    }else if (operacion != 9){
        Console.WriteLine("Ingrese el numero: ");
        numString = Console.ReadLine();
        int.TryParse(numString, out intNum1);
        switch (operacion){
            case 1:
                calc.Suma(intNum1);
                break;
            case 2:
                calc.Resta(intNum1);
                break;
            case 3:
                calc.Multiplicar(intNum1);
                break;
            case 4:
                calc.Dividir(intNum1);
                break;
        }
    }
    Console.WriteLine("\nResultado: " + calc.Resultado);
}