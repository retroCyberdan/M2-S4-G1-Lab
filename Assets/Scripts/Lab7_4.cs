using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class Lab7_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creo un personaggio e tre nemici usando i COSTRUTTORI
        //                      nome  salute lvl
        Player p1 = new Player("Cloud", 25, 10);
        
        //                         nome      salute lvl
        Enemy n1 = new Enemy("ShinRa Soldier", 12, 5);
        Enemy n2 = new Enemy("ShinRa Wolf", 12, 5);
        Enemy n3 = new Enemy("Sephiroth", 50, 10);

        p1.AttackEnemy(n1, 13);
        n2.AttackPlayer(p1, 4);
        p1.AttackEnemy(n2, 50);
        n3.AttackPlayer(p1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
