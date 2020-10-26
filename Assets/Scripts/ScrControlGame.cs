using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrControlGame : MonoBehaviour
{
    public static int puntos = 0; // Puntuación.
    public static int pickups = 0; // Núm de pickups en la escena.

    private void Update()
    {
        if (ScrControlGame.pickups == 0) JuegoAcabado();
    }

    void JuegoAcabado() 
    {
        print("¡FIN DEL JUEGO!");
    }
}
