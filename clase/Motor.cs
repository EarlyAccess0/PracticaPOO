public class Motor:PracticaPOO
{
    private int litros_de_aceite;
    private int potencia;

    public Motor(int potencia)
    {
        litros_de_aceite=0;
        this.potencia = potencia;
        this.litros_de_aceite=CalculaLitrosDeAceite(potencia);
    }
    public int getLitrosDeAceite()
    {
        return litros_de_aceite;
    }
    public void setLitrosDeAceite(int litros_de_aceite)
    {
        this.litros_de_aceite = litros_de_aceite;
    }
    public int getPotencia()
    {
        return potencia;
    }
    public void setPotencia(int potencia)
    {
        this.potencia = potencia;
    }
    
    public void IncrementarLitrosAceite(int cantidad)
    {
        litros_de_aceite+=cantidad;
    }
    private int CalculaLitrosDeAceite(int potencia)
    {
        return potencia > 100? 10: 5;
    }
}