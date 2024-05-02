using System.ComponentModel.DataAnnotations;

namespace LibraryManagerApi.Communication.Requests;

public class RequestChangeBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "O valor informado deve ser maior que zero.")]
    public double Price { get; set; }

    public int Quantity { get; set; }
}
