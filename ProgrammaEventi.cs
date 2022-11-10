// See https://aka.ms/new-console-template for more information

public class ProgrammaEventi
{
    public string Titolo { get; set; }
    List<Evento> Eventi { get; set; }

    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public void AggiungiEvento(Evento evento)
    {
        Eventi.Add(evento);
    }

    public Evento InDataEventi(DateTime data)
    {
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data)
            {
                return evento;
            }
        }
        return null;
    }

    public static void StampaInConsole (List<Evento> eventi)
    {
        foreach (Evento evento in eventi)
        {
            Console.WriteLine("{1} - {0}", evento.Titolo, evento.Data.ToString("dd/MM/yyyy"));
        }
    }

    public int NumeroEventi()
    {
        return Eventi.Count;
    }

    public void SvuotaLista()
    {
        Eventi.Clear();
    }

    public void StampaProgramma()
    {
        Console.WriteLine("{0} Programma evento:", Titolo);
        StampaInConsole(Eventi);
    }
}