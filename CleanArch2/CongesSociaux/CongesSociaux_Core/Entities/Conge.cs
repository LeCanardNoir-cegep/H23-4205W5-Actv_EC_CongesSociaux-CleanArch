using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class Conge : ABaseEntities
    {
        public DateTime DateDebut { get; set; }
        public int Duree { get; set; }
        public string Description { get; set; }


        public AEmploye Employe { get; set; }
    }
}
