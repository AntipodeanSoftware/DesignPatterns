using System;

namespace DesignPatterns.StatePattern
{
	public class ToDoState : ScrumBoardState
	{
		public ToDoState(Task task) : base(task){}

		public override void SetToDo()
		{
			Message = @"Task is already To Do";
		}

		public override void SetInProgress()
		{
			task.SetState(task.GetInProgressState ());
			Message = @"Task In Progress";
		}

		public override void SetDone()
		{
			Message = @"Task cannot be set to Done";
		}
	}
}

