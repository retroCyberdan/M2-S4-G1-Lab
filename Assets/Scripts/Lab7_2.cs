using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab7_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creo una nuova istanza e la assegno a 'p1'
        Player p1 = new Player();

        //assegno dei valori ai campi 'nome' e 'punteggio'
        p1.nome = "Guybrush Threepwood";
        //p1.punteggio = 10;//prima di rimuovere il commento, andare nella classe 'Player' e aggiungere commento a 'private int punteggio'

        //eseguo prima il metodo 'PresentatiComePirata' per mostrare il punteggio iniziale
        p1.PresentatiComePirata();

        Debug.Log($"Eppure pensavo che il matrimonio con Elaine mi avrebbe aiutato in qualche modo...");

        //quindi il metodo 'IncrementaPunteggio' per modificarne il valore
        p1.IncrementaPunteggio(80);

        //rimando in Console il unteggio modificato
        //Debug.Log($"Ah-ah! Adesso che ho sposato il Governatore più sexy dell'Area delle Tre Isole, il mio punteggio è di {p1.punteggio} !");
        //^^^^prima di rimuovere il commento, andare nella classe 'Player' e aggiungere commento a 'private int punteggio'
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
