using System.Collections;

Bok bok = new Bok(1, "Hobbiten", "Tolkien");

Console.WriteLine("1. Låna bok");
Console.WriteLine("2. Lämna tillbaka");
Console.Write("Välj: ");
string? val = Console.ReadLine();

if (val == "1")
{
    Console.Write("Ditt namn: ");
    string? namn = Console.ReadLine();

    if (bok.LanaUt(namn ?? ""))
        Console.WriteLine("Du har lånat boken!");
    else
        Console.WriteLine("Det gick inte att låna boken.");
}

tack

Varsågod!Val 2 (lämna tillbaka) gör ingenting än, så säg till om du vill ha hjälp att lägga till det.
