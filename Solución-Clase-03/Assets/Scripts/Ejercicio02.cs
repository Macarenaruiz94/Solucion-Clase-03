using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    private int fuerza;
    private int agilidad;
    private int fuerzaMax;
    private int agilidadMax;

    private void Start()
    {
        fuerza = 100;
        agilidad = 50;
        fuerzaMax = (fuerza * 2) / 5;
        agilidadMax = agilidad / 2;
    }

    private void Update()
    {
        EjecutarAtaqueEspecial();
    }

    private void EjecutarAtaqueEspecial()
    {
        if (fuerzaMax > -1 && agilidadMax > 20)

        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
}
