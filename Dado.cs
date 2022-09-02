namespace OOP.Class;
using OOP.Interface;

public abstract class Dado: IDadoInterface
{

    protected int valor;
    protected int caras;
    protected Random random;

    public Dado()
    {
        random = new Random();
    }

    public void Lanzar()
    {
        valor = random.Next(1,7);
    }

    public int MostrarNumero()
    {
        return valor;
    }

}