namespace API.CORE.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; } //ngày xuất bản
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateBy { get; set; }
        public DateTime UpdateByLasted { get; set; }
        public bool IsDelete { get; set; }
        public bool IsPublic { get; set; }
    }
}
