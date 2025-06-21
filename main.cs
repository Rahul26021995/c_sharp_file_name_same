using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name;
    public int Stock;
}

public class ProductSearch
{
    public static List<Product> Search(List<Product> products, string query, int minStock = 10)
    {
        return products
            .Where(p => p.Name.ToLower().Contains(query.ToLower()) && p.Stock >= minStock)
            .ToList();
    }
}
