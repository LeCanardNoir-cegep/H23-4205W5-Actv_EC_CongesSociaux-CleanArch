namespace CongesSociaux_Core.Entities
{
    public abstract class Employe
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateEmbauche { get; set; }

    }
}
