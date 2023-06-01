namespace EstadoEmpleado;

public enum cargo{
    
}
public class Empleados{
    public string? nombre;
    public string? apellido;
    public DateTime fdn;
    public char estadoCivil;
    public DateTime fdi;
    public double sueldo;
    public enum cargo{
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }
}