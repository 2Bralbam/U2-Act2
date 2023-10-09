using System;
using System.Collections.Generic;

namespace Unidad2_Act2.Models.Entities;

public partial class Estadisticasraza
{
    public uint Id { get; set; }

    public uint NivelEnergia { get; set; }

    public uint FacilidadEntrenamiento { get; set; }

    public uint EjercicioObligatorio { get; set; }

    public uint AmistadDesconocidos { get; set; }

    public uint AmistadPerros { get; set; }

    public uint NecesidadCepillado { get; set; }

    public virtual Razas IdNavigation { get; set; } = null!;
}
