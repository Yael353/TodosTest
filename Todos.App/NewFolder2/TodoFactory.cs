﻿namespace Todos.App.NewFolder2
{
	public class TodoFactory
	{
		List<Todo> todos = new() { new Todo { Id = 1, Completed = true, Description = "Todo1" } };

		public List<Todo> Get() => todos.GetRange(0, todos.Count);
		public bool Update(bool completed, Todo todo)
		{
			try
			{
				todo.Completed = completed;
			}
			catch
			{
				return false;
			}
			return true;
		}

		public void Delete(Todo todo) => todos.Remove(todo);

		public void Add(string description)
		{
			if (description.Length == 0)
				throw new ArgumentException("invalid to-do description");
			try
			{
				var id = todos.Count().Equals(0) ? 1 : todos.Max(t => t.Id) + 1;
				var todo = new Todo { Id = id, Description = description };
				todos.Add(todo);

			}
			catch
			{
				throw;
			}

		}

	}
}
