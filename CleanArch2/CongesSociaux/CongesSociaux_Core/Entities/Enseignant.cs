namespace CongesSociaux_Core.Entities
{
    public class Enseignant : Employe
    {
        public string Specialite { get; set; }

        public Departement Departement { get; set; }
    }
}
