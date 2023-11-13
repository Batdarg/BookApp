using System;
using System.Collections.Generic;

namespace BookAppDatos.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Chapters { get; set; }

    public int Pages { get; set; }

    public int Price { get; set; }

    public int AutorId { get; set; }

    public virtual Author Autor { get; set; } = null!;
}
