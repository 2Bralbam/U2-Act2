using System;
using System.Collections.Generic;

namespace Unidad2_Act2.Models.Entities;

public partial class Razas
{
    public uint Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? OtrosNombres { get; set; }

    public int IdPais { get; set; }

    public float PesoMin { get; set; }

    public float PesoMax { get; set; }

    public float AlturaMin { get; set; }

    public float AlturaMax { get; set; }

    public uint EsperanzaVida { get; set; }

    public virtual Caracteristicasfisicas? Caracteristicasfisicas { get; set; }

    public virtual Estadisticasraza? Estadisticasraza { get; set; }

    public virtual Paises IdPaisNavigation { get; set; } = null!;
}
