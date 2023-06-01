namespace EspacioCalculadora;

public class Calculadora{
    private double valor;
    public Calculadora(){
        valor = 0;
    }
    public double Resultado{
        get => valor;
    }
    public void Suma(double numero){
        valor += numero;
    }
    public void Resta(double numero){
        valor -= numero;
    }
    public void Multiplicar(double numero){
        valor = valor * numero;
    }
    public void Dividir(double numero){
        valor = valor / numero;
    }
    public void Limpiar(){
        valor = 0;
    }
}