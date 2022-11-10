// See https://aka.ms/new-console-template for more information


Console.WriteLine("Inserisci nome evento");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci data evento in formato (dd/mm/yyyy)");
DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Inserisci capienza massima evento");
int capienza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

try
{
    Evento evento1 = new Evento(titolo, data, capienza);
    Console.WriteLine("Dati evento:");
    Console.WriteLine("Titolo evento: {0}", evento1.Titolo);
    Console.WriteLine("Numero di posti totali: {0}", evento1.Capienza);
    Console.WriteLine("L'evento si svolgerà: {0}", evento1.ToString());

    Console.WriteLine();

    Console.WriteLine("Quanti posti desideri prenotare?");
    int prenotati = Convert.ToInt32(Console.ReadLine());
    evento1.PrenotaPosti(prenotati);
    Console.WriteLine("numero di posti prenotati: {0}", evento1.PostiPrenotati);

    bool continua = true;
    while(continua)
    {
        Console.WriteLine("Numero posti ancora disponibili: {0}", evento1.PostiDisponibili());
        Console.WriteLine();


        Console.WriteLine("Vuoi disdire dei posti? (si/no)");
        string risposta = Console.ReadLine();
        int disdetti;

        switch (risposta)
        {
            case "si":
                Console.WriteLine("Inserisci numero posti da disdire");
                disdetti = Convert.ToInt32(Console.ReadLine());
                evento1.DisdiciPosti(disdetti);
                Console.WriteLine();
                Console.WriteLine("numero di posti prenotati: {0}", evento1.PostiPrenotati);
                break;

            case "no":
                Console.WriteLine("Numero posti prenotati: {0}", evento1.PostiPrenotati);
                continua = false;
                break;
        }
    }

} catch (GestoreEventiException e)
{
    Console.WriteLine(e.Message);
}




