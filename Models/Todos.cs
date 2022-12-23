namespace dotnet_app.Models;

public class Todos {
    public int Id { get; set; }
    public String title { get; set; }
    public String contents { get; set; }
    public DateTime? date { get; set; }
}