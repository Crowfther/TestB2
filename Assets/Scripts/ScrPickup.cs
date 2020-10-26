using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPickup : MonoBehaviour
{
    [SerializeField]
    int velGiro = 30;

    public int valor = 1;

    // Start is called before the first frame update
    void Awake()  //Start pero más antes aún.
    {
        ScrControlGame.pickups++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, velGiro * Time.deltaTime);
    }
}
