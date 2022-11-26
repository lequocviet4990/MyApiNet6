namespace API.CORE.Entities
{
    public class Actor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Genda { get; set; }

        public DateTime? ReleaseDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
