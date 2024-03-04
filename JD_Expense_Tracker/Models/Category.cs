﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Category
{
    [Key]
    public int CategoryID { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }

    [Column(TypeName = "nvarchar(5)")]
    public string Icon { get; set; } = ""; //setting default values

    [Column(TypeName = "nvarchar(10)")]
    public string Type { get; set; } = "Expense";

    [NotMapped]
    public string? TitleWithIcon
    {
        get
        {
            return this.Icon + " " + this.Title;
        }
    }
}
