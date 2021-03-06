using System.Collections.Generic;
using System.Linq;

namespace Basics.Units
{
    public partial class TodoList
    {

        private readonly List<TodoItem> _todoItems = new();
        private int idCounter = 1;

        public void Add(TodoItem item)
        {
            _todoItems.Add(item with {Id = idCounter++});
        }

        public IEnumerable<TodoItem> All => _todoItems;

        public void Complete(int id)
        {
            var item = _todoItems.First(x => x.Id == id);
            _todoItems.Remove(item);

            var completedItem = item with {Complete = true};
            _todoItems.Add(completedItem);
        }
    }
}