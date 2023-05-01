using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class TypeConge : ABaseEntities
    {
        public string? Description { get; set; }
        public bool Cumulable { get; set; }
        public int NombreJours  { get; set; }

        public Periode Periode { get; set; }

    }
}
