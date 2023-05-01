namespace CongesSociaux_Core.Common
{
    public abstract class AEmploye : ABaseEntities
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateEmbauche { get; set; }

    }
}
