using System.Collections.Generic;
using System.Linq;
namespace Proyecto.Core;

public class Juego
{
    int probabPiedra;
    int probabPapel;
    int probabTijera;
    private List<Opcion> jugadasGuardadas = new List<Opcion>();

    public void almacenarInformacion(Jugada opcionActual)
    {
        guardarJugada(opcionActual);
    }
    public void guardarJugada(Jugada opcionActual)
    {
        jugadasGuardadas.Add(opcionActual.OpcionElegida);
    }

    
    public void probabilidadesTotales(List<Opcion> jugadasGuardadas)
    {
        foreach(Opcion jugada in jugadasGuardadas)
        {
            if(jugada == Opcion.Piedra){
                probabPiedra++;
            }
            if(jugada == Opcion.Papel)
            {
                probabPapel++;
            }
            if(jugada == Opcion.Tijera)
            {
                probabTijera++;
            }
        }
    }


    public void procesarEleccion(Jugada enJuego)
    {
        switch (enJuego.OpcionElegida)
        {
            case Opcion.Papel:
                
            break;
            case Opcion.Piedra:

            break;
            case Opcion.Tijera:
            
            break;

            default:

            break;
        }
    }

    public void jugadaMaquina(List<Opcion> jugadasGuardadas, Jugada enJuego)
    {
        Random numRand = new Random();
        int index = numRand.Next(0 , jugadasGuardadas.Count);
        Opcion eleccionMaquina = jugadasGuardadas[index];
    }
}
