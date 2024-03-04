using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The column(typename) need not be written everywhere only if we explictly need it for example
/// nvarchar(75) or decimal(18,2) etc.
/// 
/// </summary>
public class Transactions
{
    [Key]
    public int TransactionID { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
    public int CategoryID { get; set; }  // if not nullable then every transaction should be associated with a category
    public Category? Category { get; set; } // this is to show foreign key in Entity framework

    [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0.")]
    public int Amount { get; set; }

    public string? Note { get; set; } // nullable in db

    public DateTime Date { get; set; } = DateTime.Now;

    [NotMapped]
    public string? CategoryTitleWithIcon
    {
        get
        {
            return Category == null ? "" : Category.Icon + " " + Category.Title;
        }
    }

    [NotMapped]
    public string? FormattedAmount
    {
        get
        {
            return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0");
        }
    }

}
