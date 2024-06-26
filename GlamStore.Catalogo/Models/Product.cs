﻿namespace GlamStore.Catalogo.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public float Stock { get; set; }

    #region Category
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    #endregion

}
