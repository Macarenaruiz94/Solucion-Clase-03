using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    static void EncontrandoEnemigo()
    {
        string[] enemigosNombre = { "Orco", "Ara�a", "Golem", "Goblin" };
        var resultado = enemigosNombre.ToLookup(w => w.Length);
        

        for (int i = 0; i <= enemigosNombre.Length; i++)
        {
            foreach (string enemigo in resultado[i])
            {
                Debug.Log("Se encontr� " + enemigo);
            }
        } Debug.Log("No se encontr� enemigo");

    }
}
