// See https://aka.ms/new-console-template for more information


Console.WriteLine("Qual è il titolo del Programma eventi?");
string titoloProgramma = Console.ReadLine();

ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);

Console.WriteLine("Quanti eventi vuoi aggiungere?");
int numEventi = Convert.ToInt32(Console.ReadLine());

while ( programma.NumeroEventi() < numEventi)
{
    Console.WriteLine("Inserisci nome evento");
    string titoloEvento = Console.ReadLine();

    Console.WriteLine("Inserisci data evento in formato (dd/mm/yyyy)");
    DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine("Inserisci capienza massima evento");
    int capienzaEvento = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    
    try
    {
        Evento evento = new Evento(titoloEvento, dataEvento, capienzaEvento);

        programma.AggiungiEvento(evento, programma.Eventi);
    }
    catch (GestoreEventiException e)
    {
        Console.WriteLine(e.Message);
    }
    
    
}

Console.WriteLine("Il programma ha {0} eventi", programma.NumeroEventi());
Console.WriteLine();
programma.StampaProgramma();
Console.WriteLine();
Console.WriteLine("inserisci una data in formato (yy/MM/yyy)");
DateTime dataUtente = Convert.ToDateTime(Console.ReadLine());
List<Evento> listaEventiData = new List<Evento>();
programma.InDataEventi(dataUtente, listaEventiData);




//Console.WriteLine("Inserisci nome evento");
//string titolo = Console.ReadLine();

//Console.WriteLine("Inserisci data evento in formato (dd/mm/yyyy)");
//DateTime data = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine("Inserisci capienza massima evento");
//int capienza = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//try
//{
//    Evento evento1 = new Evento(titolo, data, capienza);
//    Console.WriteLine("Dati evento:");
//    Console.WriteLine("Titolo evento: {0}", evento1.Titolo);
//    Console.WriteLine("Numero di posti totali: {0}", evento1.Capienza);
//    Console.WriteLine("L'evento si svolgerà: {0}", evento1.ToString());

//    Console.WriteLine();

//    Console.WriteLine("Quanti posti desideri prenotare?");
//    int prenotati = Convert.ToInt32(Console.ReadLine());
//    evento1.PrenotaPosti(prenotati);
//    Console.WriteLine("numero di posti prenotati: {0}", evento1.PostiPrenotati);

//    bool continua = true;
//    while(continua)
//    {
//        Console.WriteLine("Numero posti ancora disponibili: {0}", evento1.PostiDisponibili());
//        Console.WriteLine();


//        Console.WriteLine("Vuoi disdire dei posti? (si/no)");
//        string risposta = Console.ReadLine();
//        int disdetti;

//        switch (risposta)
//        {
//            case "si":
//                Console.WriteLine("Inserisci numero posti da disdire");
//                disdetti = Convert.ToInt32(Console.ReadLine());
//                evento1.DisdiciPosti(disdetti);
//                Console.WriteLine();
//                Console.WriteLine("numero di posti prenotati: {0}", evento1.PostiPrenotati);
//                break;

//            case "no":
//                Console.WriteLine("Numero posti prenotati: {0}", evento1.PostiPrenotati);
//                continua = false;
//                break;
//        }
//    }

//} catch (GestoreEventiException e)
//{
//    Console.WriteLine(e.Message);
//}
