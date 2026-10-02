public class Bok
{
    public int Id { get; }
    public string Title { get; }
    public string Author { get; }
    public bool IsLoaned { get; private set; }
    public string? LoanedTo { get; private set; }

    public Bok(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
        IsLoaned = false;
    }

    public bool LanaUt(string namn)
    {
        if (string.IsNullOrWhiteSpace(namn)) return false;
        if (IsLoaned) return false;
        IsLoaned = true;
        LoanedTo = namn;
        return true;
    }

    public bool LamnaTillbaka()
    {
        if (!IsLoaned) return false;
        IsLoaned = false;
        LoanedTo = null;
        return true;
    }
}
