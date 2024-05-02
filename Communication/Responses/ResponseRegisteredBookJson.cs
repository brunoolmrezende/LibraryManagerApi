namespace LibraryManagerApi.Communication.Responses;

public class ResponseRegisteredBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

