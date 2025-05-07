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
        Player3 p1 = new Player3();

        //assegno dei valori ai campi 'nome' e 'punteggio'
        p1.nome = "Guybrush Threepwood";
        p1.GetPunteggio();//essendo 'p1.punteggio privato', uso il Getter per richiamarlo
        //accedo alla funzione 'SetPunteggio'
        p1.SetPunteggio(40);

        //eseguo prima il metodo 'PresentatiComePirata' per mostrare il punteggio iniziale
        p1.PresentatiComePirata();

        Debug.Log($"Eppure pensavo che il matrimonio con Elaine mi avrebbe aiutato in qualche modo...");

        //quindi il metodo 'IncrementaPunteggio' per modificarne il valore
        p1.IncrementaPunteggio(80);
        Debug.Log($"Mi spiace, ma ogni pirata che si rispetti non può scendere MAI sotto lo {p1.GetPunteggio()}.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
