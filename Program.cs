// See https://aka.ms/new-console-template for more information
using EstadoEmpleado;
bool funciona = false;
string? stringNum = "";
int dato = 0;
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
funciona = false;
while (!funciona){
    Console.WriteLine("Estado Civil\n1)Soltero\n2)Casado\n3)Otro");
    int.TryParse(stringNum, out dato);
    if(dato < 1 | dato > 3){
        Console.WriteLine("Ingrese una entrada valida.");
    }else{
        funciona = true;
    }
}
switch (dato){
    case 1:
        EmpleadoNuevo.EstadoCivil = estadoCiviles.Soltero;
        break;
    case 2:
        EmpleadoNuevo.EstadoCivil = estadoCiviles.Casado;
        break;
    case 3:
        EmpleadoNuevo.EstadoCivil = estadoCiviles.Otros;
        break;
}
funciona = false;
while (!funciona){
    Console.WriteLine("Sexo\n1)Masculino\n2)Femenino\n3)Otro");
    int.TryParse(stringNum, out dato);
    if(dato < 1 | dato > 3){
        Console.WriteLine("Ingrese una entrada valida.");
    }else{
        funciona = true;
    }
}
switch (dato){
    case 1:
        EmpleadoNuevo.Sexo = sexos.Masculino;
        break;
    case 2:
        EmpleadoNuevo.Sexo = sexos.Femenino;
        break;
    case 3:
        EmpleadoNuevo.Sexo = sexos.Otro;
        break;
}
