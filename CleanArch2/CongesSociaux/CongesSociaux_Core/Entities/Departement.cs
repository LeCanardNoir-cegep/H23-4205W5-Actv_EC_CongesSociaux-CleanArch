namespace CongesSociaux_Core.Entities
{
    public class Departement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        public List<Enseignant> Enseignants { get; set; }

    }
}
