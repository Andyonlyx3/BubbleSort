namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
            //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
            //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

            int[] werte = { 4, 33, 7, 1, 23, 12 };

            for (int i = 0; i < werte.Length - 1; i++) //Schleife 1 die Läuft bis alle Zahlen sortiert sind.
            {
                for (int j = 0; j < werte.Length - i - 1; j++) //Schleife 2 innerhalb von Schleife 1, die die Werte innerhalb des Arrays vergleicht.
                {
                    if (werte[j] > werte[j + 1]) //Tauscht die Werte im Array, wenn die Aktuelle Zahl größer ist als die nächste
                    {
                        int tausch = werte[j];   
                        werte[j] = werte[j + 1];  //mit hilfe der variablen "tausch" werden nun die zahlen innerhalb des Arrays getauscht 
                        werte[j + 1] = tausch;
                    }
                }
            }
            Console.WriteLine(string.Join(" - ", werte));
        }
    }
}
