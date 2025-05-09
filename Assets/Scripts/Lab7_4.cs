using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class Lab7_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.nome = "Cloud";
        
        
        Enemy n1 = new Enemy();
        n1.nome = "ShinRa Soldier";
        n1.salute = 20;
        n1.livello = 5;

        Enemy n2 = new Enemy();
        n2.nome = "ShinRa Wolf";
        n2.salute = 12;
        n2.livello = 5;

        Enemy n3 = new Enemy();
        n3.nome = "Sephiroth";
        n3.salute = 50;
        n3.livello = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
