using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    [SerializeField] public string nome;
    [SerializeField] public int salute;
    [SerializeField] public int livello;

    public int SubisciDanno (int danno)
    {
        salute -= danno;
        if (salute < 0)
        {
            salute = 0;
            Debug.Log($"La salute del {nome} non può scendere sotto lo zero!");
        }
        return salute;
    }

}
