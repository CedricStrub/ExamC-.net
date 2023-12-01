namespace Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public DateOnly Birthdate { get; set; }

        public StudentGroup? Group { get; set; } 
    }
}