using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class Enseignant : AEmploye
    {
        public string Specialite { get; set; }

        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }
}
