// See https://aka.ms/new-console-template for more information


Console.WriteLine("Inserisci nome evento");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci data evento");
DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Inserisci capienza massima evento");
int capienza = Convert.ToInt32(Console.ReadLine());

try
{
    Evento evento1 = new Evento(titolo, data, capienza);

    Console.WriteLine(evento1.Titolo);
    Console.WriteLine(evento1.Data.ToString());
    Console.WriteLine(evento1.Capienza);
    Console.WriteLine(evento1.ToString());

} catch (TitoloException e)
{
    Console.WriteLine(e.Message);

} catch (CapienzaException e)
{
    Console.WriteLine(e.Message);

} catch (DataPassataException e)
{
    Console.WriteLine(e.Message);
}

