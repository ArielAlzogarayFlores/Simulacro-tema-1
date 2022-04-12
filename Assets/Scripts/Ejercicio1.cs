using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float monto;
    public char moneda;
    
    void Start()
    {
        if (monto >= 1000)
            switch (moneda)
            {
                case 'D':

                    Debug.Log("$"+monto+ " pesos argentinos equivalen a $" + monto / 112+" dolares.");
                    break;

                case 'R':

                    Debug.Log("$"+monto+ " pesos argentinos equivalen a $" + monto / 24+" reales.");
                    break;

                case 'E':

                    Debug.Log("$" + monto + " pesos argentinos equivalen a $" + monto / 122 + " euros.");
                    break;

                default:

                    Debug.Log("Opción de moneda extranjera no válida.");
                    break;
            }
        else
        {
            Debug.Log("El monto mínimo es $1000.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
