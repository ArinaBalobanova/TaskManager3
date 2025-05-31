
namespace TaskManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullDescription { get; set; }
        public DateTime Deadline { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"{Title,-30} | {FullDescription,-50} | {Deadline:dd.MM.yyyy} | {AssignedTo,-20}";
        }
    }
}
