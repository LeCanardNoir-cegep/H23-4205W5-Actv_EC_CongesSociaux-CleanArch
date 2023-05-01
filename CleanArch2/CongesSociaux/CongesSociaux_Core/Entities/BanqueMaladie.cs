using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class BanqueMaladie : ABaseEntities
    {
        public int Solde { get; set; }

        public Periode Periode { get; set; }
        public AEmploye Employe { get; set; }
    }
}
