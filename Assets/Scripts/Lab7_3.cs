using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Lab7_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creo una nuova istanza e la assegno a 'p1'
        Player p1 = new Player();

        //assegno dei valori ai campi 'nome' e 'punteggio'
        p1.nome = "Guybrush Threepwood";
        p1.GetPunteggio();

        //eseguo prima il metodo 'PresentatiComePirata' per mostrare il punteggio iniziale
        p1.PresentatiComePirata();

        Debug.Log($"Eppure pensavo che il matrimonio con Elaine mi avrebbe aiutato in qualche modo...");

        //quindi il metodo 'IncrementaPunteggio' per modificarne il valore
        p1.IncrementaPunteggio(80);

        //accedo alla funzione 'SetPunteggio'
        p1.SetPunteggio(-5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
