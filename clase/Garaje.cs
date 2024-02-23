public class Garaje:PracticaPOO
{
    private Coche? cocheAtendido;
    private string averiaAsociada;
    private int cochesAtendidos;
    private double importeTotalAverias;

    public Garaje()
    {
        cocheAtendido = null;
        averiaAsociada = "";
        cochesAtendidos = 0;
        importeTotalAverias= 0;
    }

    public bool AceptarCoche(Coche coche, string averia)
    {
        if (cocheAtendido != null)
        {
            return false;
        }

        cocheAtendido = coche;
        averiaAsociada = averia;
        cochesAtendidos++;
        return true;
    }

    public void DevolverCoche()
    {
        cocheAtendido = null;
        averiaAsociada = "";
    }

    public void AcumularAveria(double importe)
    {
        importeTotalAverias += importe;
    }

    public int GetCochesAtendidos()
    {
        return cochesAtendidos;
    }

    public double GetImporteTotalAverias()
    {
        return importeTotalAverias;
    }
}
