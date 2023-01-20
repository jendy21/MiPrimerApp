﻿using System;
using System.Collections.Generic;

namespace MiprimerApp.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int IdCategoria { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
}
