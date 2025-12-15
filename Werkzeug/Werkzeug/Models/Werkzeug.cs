using System;
using System.Collections.Generic;

namespace Werkzeug.Models;

public partial class Werkzeug
{
    public int WerkzeugId { get; set; }

    public string Bezeichnung { get; set; } = null!;

    public string Kategorie { get; set; } = null!;

    public string Hersteller { get; set; } = null!;

    public int Kaufjahr { get; set; }

    public string Zustand { get; set; } = null!;

    public decimal Preis { get; set; }
}
