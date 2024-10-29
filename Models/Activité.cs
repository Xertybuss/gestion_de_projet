namespace projectManager.Models
{
    abstract public class Activité
    {
        public string titre { get; set; }
        public string etat { get; set; }
        public string description { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
    }
}
