namespace Basics.Units
{
    public partial class TodoList
    {
        public record TodoItem(string Content)
        {
            public int Id { get; init; }
            public bool Complete { get; init; }
        }
    
    }
}