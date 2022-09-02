namespace OOP.Class;
using OOP.Interface;


public class JuegoDado
{
    private IDadoInterface Dado1, Dado2;

    public JuegoDado(IDadoInterface D1, IDadoInterface D2)
    {
        Dado1=D1;
        Dado2=D2;
    }

    public void Iniciar()
    {
        Dado1.Lanzar();
        Dado2.Lanzar();
    }

    private bool Evaluar()
    {
        return Dado1.MostrarNumero() == Dado2.MostrarNumero();
    }

    public string Finalizar()
    {
        if(Evaluar())
        {
            return"Ganaste";
        }
        return "Perdiste";
    }

}