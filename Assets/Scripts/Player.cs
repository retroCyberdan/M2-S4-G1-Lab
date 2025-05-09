using System.Collections;
using UnityEngine;

[System.Serializable]
public class Player
{
    //Creo i campi nome e punteggio
    [SerializeField] public string nome;//sono entrambi 'public' altrimenti non posso richiamarle all'esterno
    [SerializeField] private int punteggio;//inoltre, li rendo 'SerializeField'
    
    //variabili e costruttore aggiunti per 'Lab7_4':
    [SerializeField] public int salute;
    [SerializeField] public int livello;

    //Creo un COSTRUTTORE che chiamo 'Player' con parametri di DEFAULT
    public Player()
    {
        nome = "(-)";
        salute = 0;
        livello = 1;
    }
    public Player (string nome, int salute, int livello)
    {
        this.nome = nome;
        this.salute = salute;
        this.livello = livello;
    }
    
    //Per puro divertimento XD, creo due funzioni che sostanzialmente fanno la stessa cosa, cambia solamente il testo
    public void PresentatiComePirata()
    {
        Debug.Log($"Ciao! Sono {nome} e con un punteggio di {punteggio} sono un TEMIBILE PIRATA!");
    }

    public void Presentati()
    {
        Debug.Log($"Mi chiamo {nome} e con un punteggio di {punteggio} sono la persona più sexy di tutti i Caraibi <3");
    }

    public int IncrementaPunteggio(int punteggio)
    {
        this.punteggio += punteggio;//uso il this' per differenziare le 2 variabili (this.variabileMembro = variabileLocale)
        return this.punteggio;
    }

    public int GetPunteggio()
    {
        return this.punteggio;
    }

    public void SetPunteggio(int punteggio)
    {
        if (punteggio < 0)
        {
            this.punteggio = 0;
            Debug.Log($"Mi spiace, ma ogni pirata che si rispetti non potrebbe MAI scendere sotto lo {this.punteggio}.");
        }
        else
        {
            this.punteggio = punteggio;
        }
    }

    public bool IsVincitore()
    {
        if (punteggio >= 100)
        {
            return true;
        }
        return false;
    }

    //Creo i metodi per attaccare il nemico e per subire il danno
    public void AttackEnemy(Enemy nemico, int danno)
    {
        nemico.SubisciDanno(danno);
        Debug.Log($"{nome} ha colpito {nemico.nome} infliggendogli {danno} danni.");
        Debug.Log($"A {nemico.nome} restano {nemico.salute} HP.");
    }

    public int SubisciDanno (int danno)
    {
        salute -= danno;
        return salute;
    }
}
