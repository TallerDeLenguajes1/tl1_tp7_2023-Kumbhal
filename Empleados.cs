namespace EstadoEmpleado;
public enum estadoCiviles{
    Soltero,
    Casado,
    Otros
}
public enum sexos{
    Masculino,
    Femenino,
    Otro
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
    }
    public void Edad(DateTime nacimiento){
        valor = DateTime.Now.Year - nacimiento.Year;
    }
}