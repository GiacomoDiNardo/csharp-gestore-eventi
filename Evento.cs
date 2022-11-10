// See https://aka.ms/new-console-template for more information





public class Evento
{

    public string Titolo {
        get
        {
            return _titolo;
        }
        set
        {
            if (value == "" || value == null)
            {
                throw new GestoreEventiException("Titolo non valido");
            }
            else
            {
                _titolo = value;
            }
        }
    }
    public DateTime Data
    {
        get
        {
            return _data;
        }
        set
        {
            if (DateTime.Compare(oggi, value) > 0)
            {
                throw new GestoreEventiException("Questo evento è già passato");
            }

            _data = value;
        }
    }
    public int Capienza
    {
        get
        {
            return _capienza;
        }
        private set
        {
            if (value <= 0)
            {
                throw new GestoreEventiException("Capienza non valida");
            }
            _capienza = value;
        }
    }
    public int PostiPrenotati { get; private set; }

    public Evento(string titolo, DateTime data, int capienza)
    {
        Titolo = titolo;
        Data = data;
        Capienza = capienza;
        PostiPrenotati = 0;
    }

    private string _titolo;
    private int _capienza;
    private DateTime _data;
    private DateTime oggi = DateTime.Now; 
    public int PrenotaPosti(int postiPrenotati)
    {
        PostiPrenotati += postiPrenotati;
        return PostiPrenotati;
    }

    public int DisdiciPosti(int postiDisdetti)
    {
        PostiPrenotati -= postiDisdetti;
        return PostiPrenotati;
    }

    public int PostiDisponibili()
    {
        int disponibili = Capienza - PostiPrenotati;
        return disponibili;
    }

    public override string ToString()
    {
        return Data.ToString("dd/MM/yyyy") + " - " + Titolo;
    }
}