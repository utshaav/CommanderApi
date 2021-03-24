namespace Commander.Dtos
{
    public class CommandReadDto
    {

        public int Id { get; set; }
        // [Requided]
        public string HowTo { get; set; }
        public string Line { get; set; }
        // public string Platform { get; set; }
    }
}