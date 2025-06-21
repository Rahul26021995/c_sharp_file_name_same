using System;
using System.Collections.Generic;
using System.Linq;

public class Invoice
{
    public string Client;
    public DateTime DueDate;
}

public class InvoiceSearch
{
    public static List<Invoice> Search(List<Invoice> invoices, string clientQuery)
    {
        DateTime today = DateTime.Today;
        return invoices
            .Where(inv => inv.Client.ToLower().Contains(clientQuery.ToLower()) && inv.DueDate > today)
            .ToList();
    }
}
