// See https://aka.ms/new-console-template for more information
using EstadoEmpleado;
bool funciona = false;
string? stringNum = ""; 
int anio = 0;
int mes = 0;
int dia = 0;
Empleados EmpleadoNuevo = new Empleados();
while (!funciona){
    Console.Write("Ingrese el nombre del empleado: ");
    stringNum = Console.ReadLine();
    if (stringNum == null){
        Console.WriteLine("Nombre invalido");
    }else{
        funciona = true;
    }
}
EmpleadoNuevo.nombre = stringNum;
funciona = false;
while (!funciona){
    Console.Write("Ingrese el apellido del empleado: ");
    stringNum = Console.ReadLine();
    if (stringNum == null){
        Console.WriteLine("Apellido invalido");
    }else{
        funciona = true;
    }
}
EmpleadoNuevo.apellido = stringNum;
funciona = false;
while (!funciona){
    Console.WriteLine("Ingrese el dia de nacimiento: ");
    int.TryParse(stringNum, out anio);
    if (anio <= 0){
        Console.WriteLine("Ingrese un anio valido.");
    }else{
        Console.WriteLine("Ingres el mes de nacimiento: ");
        int.TryParse(stringNum, out mes);
        if (mes < 1 | mes > 12){
            Console.WriteLine("Ingrese un mes valido.");
        }else{
            Console.WriteLine("Ingrese dia de nacimiento: ");
            int.TryParse(stringNum, out dia);
            if (dia < 1 | dia > 31){
                Console.WriteLine("Ingrese un dia valido.");
            }else{
                funciona = true;
            }
        }
    }
}
EmpleadoNuevo.fdn = new DateTime(anio, mes, dia);
