

public class Coche:PracticaPOO
{
    private Motor motor;
    private string  marca;
    private int modelo;

    private double precio_por_averia;
    public Coche(string marca, int modelo)
    {
        this.motor= new Motor(100);
        this.marca = marca;
        this.modelo = modelo;
    }

    public Motor GetMotor()
    {
        return motor;
    }
    public string getMarca()
    {
        return marca;
    }
    public int getModelo()
    {
        return modelo;
    }

    private void AcumuladorDeAverias(double averias)
    {
        precio_por_averia+=averias;
    }

    internal object AcumuladorDeAverias()
    {
        throw new NotImplementedException();
    }
}
