using System.Collections;
using UnityEngine;

[System.Serializable]
public class Player
{
    //Creo i campi nome e punteggio
    [SerializeField] public string nome;//sono entrambi 'public' altrimenti non posso richiamarle all'esterno
    [SerializeField] private int punteggio;//inoltre, li rendo 'SerializeField'

    [SerializeField] public int salute;//aggiunte per 'Lab7_4'
    
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
}
