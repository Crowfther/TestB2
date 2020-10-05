using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField]
    float velocidad=3;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float x, y; //Para leer el gamepad.

        x = Input.GetAxis("Horizontal");    //Leer movimiento horizontal.
        y = Input.GetAxis("Vertical");      //Leer movimiento vertical.

        //print ("Horizontal:" + x + " / Vertical: " + y);

        transform.Translate(x*Time.deltaTime*velocidad, y*Time.deltaTime*velocidad, 0);
    }
}
