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
    public string? nombre;
    public string? apellido;
    public DateTime fdn;
    public estadoCiviles EstadoCivil;
    public sexos Sexo;
    public DateTime fdi;
    public double sueldo;
    public cargos cargo;
}