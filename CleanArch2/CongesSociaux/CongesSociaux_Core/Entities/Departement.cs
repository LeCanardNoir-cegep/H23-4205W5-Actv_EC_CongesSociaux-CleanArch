using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class Departement : ABaseEntities
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public List<Enseignant> Enseignants { get; set; }

    }
}
