using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// DESCRIPCION:
///             Script utilizado para gestionar acciones relacionadas con la UI.
/// AUTOR:      Aitor Gonzalez
/// DATA:       26/10/2020
/// VERSION:    1.0
/// CONTROL DE VERSIONES
///     1.0 Primera versión; Mostrar puntuación.
/// </summary>
public class ScrUI : MonoBehaviour
{
    [SerializeField]
    public Text puntuacion; // Para acceder al elemento de la UI.
    public Text restantes; // Para acceder al elemento de la UI.
    public Text tiempo; // Para acceder al elemento tiempo de la UI.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = "Puntuación: " + ScrControlGame.puntos;
        restantes.text = "Pickups Restantes: " + ScrControlGame.pickups;
        tiempo.text = "TIEMPO: " + Time.fixedTime;
    }
}
