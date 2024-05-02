using System.ComponentModel.DataAnnotations;

namespace LibraryManagerApi.Communication.Requests;

public class RequestRegisterBookJson
{
    [Required(ErrorMessage = "O campo 'Title' é obrigatório.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo 'Author' é obrigatório.")]
    public string Author { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo 'Genre' é obrigatório.")]
    public BookGenre Genre { get; set; }

    [Required(ErrorMessage = "O campo 'Price' é obrigatório.")]
    [Range(0.01, double.MaxValue,ErrorMessage = "O valor informado deve ser maior que zero.")]
    public double Price { get; set; }

    [Required(ErrorMessage = "O campo 'Quantity' é obrigatório.")]
    public int Quantity { get; set; }
}
