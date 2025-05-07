
using UnityEngine;

[System.Serializable]
public class Player
{
    //Creo i campi nome e punteggio
    public string nome;//sono entrambi 'public' altrimenti non posso richiamarle all'esterno
    //public punteggio;
    private int punteggio = 10;

    //Per puro divertimento XD, creo due funzioni che sostanzialmente fanno la stessa cosa, cambia tuttavia il testo
    public void PresentatiComePirata()
    {
        Debug.Log($"Ciao! Sono {nome} e sono un TEMIBILE PIRATA! (Anche se il mio punteggio è di {punteggio} -__-");
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
        return punteggio;
    }

    public void SetPunteggio(int punteggio)
    {
        if (punteggio > 0)
        {
            this.punteggio = punteggio;
        }
        else
        {
            this.punteggio = 0;
            Debug.Log($"Mi spiace, ma ogni pirata che si rispetti non può scendere MAI sotto lo {this.punteggio}.");
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
