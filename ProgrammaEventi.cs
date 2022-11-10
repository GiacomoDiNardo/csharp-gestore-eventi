// See https://aka.ms/new-console-template for more information

public class ProgrammaEventi
{
    public string Titolo { get; set; }
    public List<Evento> Eventi { get; set; }

    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public void AggiungiEvento(Evento evento, List<Evento> lista)
    {
        lista.Add(evento);
    }

    public List<Evento> InDataEventi(DateTime data, List<Evento> lista)
    {
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data)
            {
               AggiungiEvento(evento, lista) ;
            }
        }

        StampaLista(lista, data);
        return lista;
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

    public static void StampaLista(List<Evento> lista, DateTime data)
    {
        Console.WriteLine("in data {0} ci sono questi eventi:", data.ToString("dd/MM/yyyy"));
        foreach (Evento evento in lista)
        {
            Console.WriteLine(data.ToString("dd/MM/yyyy") + " - " + evento.Titolo);
        }
    }
}