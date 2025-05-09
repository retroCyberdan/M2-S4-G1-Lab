using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab7_1 : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
