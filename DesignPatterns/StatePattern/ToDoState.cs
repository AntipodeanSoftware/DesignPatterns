using System;

namespace DesignPatterns.StatePattern
{
	public class ToDoState : ScrumBoardState
	{
		public ToDoState(Task task) : base(task){}

		public override void SetToDo()
		{
			Console.WriteLine(String.Format("{0} is already To Do", base._task.Name));
		}

		public override void SetInprogress()
		{
			Console.WriteLine(String.Format("{0} is In Progress", base._task.Name));
			_task.SetState(_task.GetInProgressState ());
		}

		public override void SetDone()
		{
			Console.WriteLine(String.Format("{0} cannot be set to Done", base._task.Name));
		}
	}
}

