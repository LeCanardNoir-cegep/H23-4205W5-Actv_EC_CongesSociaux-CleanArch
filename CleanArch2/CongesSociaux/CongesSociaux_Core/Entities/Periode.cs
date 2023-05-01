using CongesSociaux_Core.Common;

namespace CongesSociaux_Core.Entities
{
    public class Periode : ABaseEntities
    {
        public string? PeriodeName { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; }
       
        public bool PeriodeActive { get; set; }
        
        public TypeEmploye TypeEmploye { get; set; }
        public List<TypeConge> TypeConges { get; set; }
        public List<BanqueMaladie> BanqueMaladies { get; set; }

    }
}
