using System;

namespace DesignPatterns.StatePattern
{
	public class ToDoState : ScrumBoardState
	{
		public ToDoState(Task task) : base(task){}

		public override void SetToDo()
		{
			Message = String.Format("{0} is already To Do", task.Name);
		}

		public override void SetInProgress()
		{
			Message = String.Format("{0} is In Progress", task.Name);
			task.SetState(task.GetInProgressState ());
		}

		public override void SetDone()
		{
			Message = String.Format("{0} cannot be set to Done", task.Name);
		}
	}
}

