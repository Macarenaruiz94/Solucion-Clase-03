using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    public string acci�n;
    private void Update()
    {
        EjecutarAcci�n();
    }

    void EjecutarAcci�n()
    {
        switch (acci�n)
        {
            case "Heal":
                Debug.Log("Me cur�");
                break;
            case "Attack":
                Debug.Log("Hago da�o");
                break;
            case "Special Attack":
                Debug.Log("Empiezo a girar como trompo");
                break;

        }
    }
}
