namespace GravityBookstore.ModelsDto;

public class BookDto
{
    public int Book_id { get; set; }
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
}

public class BookPostDto
{
    public string Title { get; set; }
    public string Isbn13 { get; set; }
    public int Book_language_id { get; set; }
    public int Num_pages { get; set; }
    public DateOnly Publication_date { get; set; }
    public int Publisher_id { get; set; }
}