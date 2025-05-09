using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    [SerializeField] public string nome;
    [SerializeField] public int salute;
    [SerializeField] public int livello;

    //Creo un COSTRUTTORE che chiamo 'Enemy' con parametri di DEFAULT
    public Enemy()
    {
        nome = "(-)";
        salute = 0;
        livello = 1;
    }

    //faccio un OVERLOAD dello stesso che assegna i valori tra parentesi
    public Enemy(string nome, int salute, int livello)
    {
        this.nome = nome;
        this.salute = salute;
        this.livello = livello;
    }

    //Creo il metodo per il calcolo del danno
    public int SubisciDanno(int danno)
    {
        salute -= danno;
        if (salute < 0)
        {
            salute = 0;
            Debug.Log($"La salute del {nome} non può scendere sotto lo zero!");
        }
        return salute;
    }

    public void AttackPlayer (Player giocatore, int danno)
    {
        giocatore.SubisciDanno(danno);
        Debug.Log($"{nome} ha colpito {giocatore.nome} infliggendogli {danno} danni.");
        Debug.Log($"A {giocatore.nome} restano {giocatore.salute} HP.");
    }
}
