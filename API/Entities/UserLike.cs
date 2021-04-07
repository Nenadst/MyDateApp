namespace API.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; }
<<<<<<< HEAD
        public int SourceUserId { get; set; }
=======
        public int? SourceUserId { get; set; }
>>>>>>> 42eedab (Initial commit)

        public AppUser LikedUser { get; set; }
        public int LikedUserId { get; set; }
    }
}