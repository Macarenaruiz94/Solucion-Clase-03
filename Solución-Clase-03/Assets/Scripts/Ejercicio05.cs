using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    public string acción;
    private void Update()
    {
        EjecutarAcción();
    }

    void EjecutarAcción()
    {
        switch (acción)
        {
            case "Heal":
                Debug.Log("Me curé");
                break;
            case "Attack":
                Debug.Log("Hago daño");
                break;
            case "Special Attack":
                Debug.Log("Empiezo a girar como trompo");
                break;

        }
    }
}
