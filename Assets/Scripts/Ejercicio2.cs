using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public string nombreA;
    public int anioA;
    public char orientA;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreA == "" || anioA < 1 || anioA > 5)
        {
            Debug.Log("Error");
        }
        else if (orientA != 'T' && orientA != 'D' && orientA != 'G' && orientA != 'M' && orientA != 'H')
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H.");
        }
        else if (anioA < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico.");
        }
        else
        {
            Debug.Log("!Muchas gracias " + nombreA + "¡");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
