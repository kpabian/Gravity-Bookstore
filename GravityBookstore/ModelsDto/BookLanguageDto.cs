namespace GravityBookstore.ModelsDto;

public class BookLanguageDto
{
    public int Language_id { get; set; }
    public string Language_code { get; set; }
    public string Language_name { get; set; }
}

public class BookLanguagePostDto
{
    public string Language_code { get; set; }
    public string Language_name { get; set; }
}
