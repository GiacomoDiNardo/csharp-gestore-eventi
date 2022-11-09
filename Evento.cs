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
            if (_titolo == "" || _titolo == null)
            {
                throw new TitoloException("Titolo non valido");
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
            if (DateTime.Compare(oggi, _data) > 0)
            {
                throw new DataPassataException("Questo evento è già passato");
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
            if (_capienza <= 0)
            {
                throw new CapienzaException("Capienza non valida");
            }
            _capienza = value;
        }
    }
    public int PostiPrenotati { get; private set; }

    public Evento(string titolo, DateTime data, int capienza)
    {
        _titolo = titolo;
        Titolo = _titolo;
        _data = data;
        Data = _data;
        _capienza = capienza;
        Capienza = _capienza;
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