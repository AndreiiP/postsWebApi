namespace postsWebApi.Dtos.Post
{
    public class UpdatePostDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}