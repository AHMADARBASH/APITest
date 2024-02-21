namespace APITest.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Review Reviewer { get; set; }
        public Pokemon Pokemonoke { get; set; }
    }

}
