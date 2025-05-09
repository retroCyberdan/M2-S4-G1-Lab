using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab7_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Istanzio il primo 'Player' e gli assegno dei valori ai campi 'nome' e 'punteggio'
        Player p1 = new Player();
        p1.nome = "Guybrush Threepwood";
        p1.SetPunteggio(-2);

        //Istanzio il secondo 'Player' e gli assegno dei valori ai campi 'nome' e 'punteggio'
        Player p2 = new Player();
        p2.nome = "Elaine Marley";
        p2.SetPunteggio(100);

        p1.PresentatiComePirata();
        p2.Presentati();

        Debug.Log($"{p1.nome}: Eppure pensavo che il matrimonio con Elaine mi avrebbe aiutato in qualche modo...");

        //quindi il metodo 'IncrementaPunteggio' per modificare il valore di 'punteggio'
        p1.IncrementaPunteggio(80);
        Debug.Log("(MANOMETTENDO IL PUNTEGGIO...)");

        //rimando in Console il unteggio modificato
        Debug.Log($"{p1.nome}: Ah-ah! Adesso che ho sposato il Governatore più sexy dell'Area delle Tre Isole, il mio punteggio è di {p1.GetPunteggio()}!");

        p2.IncrementaPunteggio(30);

        Debug.Log($"{p2.nome}: Stai calmo {p1.nome}, ti ricordo che stai parlando con il Governatore di Melee Island! PRENDI QUESTO BEL {p2.GetPunteggio()}!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
