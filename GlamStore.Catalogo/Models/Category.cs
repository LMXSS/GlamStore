using System.Collections.ObjectModel;

namespace GlamStore.Catalogo.Models;

public class Category
{
    public Category()
    {
        Products = new Collection<Product>();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<Product> Products { get; set; }

}
