namespace EstadoEmpleado;
public enum estadoCiviles{
    Soltero = 1,
    Casado = 2,
    Otros = 3
}
public enum sexos{
    Masculino = 1,
    Femenino = 2,
    Otro = 3
}
public enum cargos{
    
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
}    
public class Empleados{
    private double valor = 0;
    public string? nombre;
    public string? apellido;
    public DateTime fdn;
    public estadoCiviles EstadoCivil;
    public sexos Sexo;
    public DateTime fdi;
    public double sueldo;
    public cargos cargo;
    public double Resultado{
        get => valor;
    }

    public void Antiguedad(DateTime ingreso){
        valor = DateTime.Now.Year - ingreso.Year;
        Console.WriteLine(valor);
    }
    public void Edad(DateTime nacimiento){
        valor = DateTime.Now.Year - nacimiento.Year;
        Console.WriteLine(valor);
    }
    public void Jubilacion(DateTime nacimiento, sexos sexoEmpleado){
        valor = DateTime.Now.Year - nacimiento.Year;
        if (sexoEmpleado == sexos.Femenino){
            valor = 60 - valor;
        }else{
            valor = 65 - valor;
        }
        Console.WriteLine(valor);
    }
}