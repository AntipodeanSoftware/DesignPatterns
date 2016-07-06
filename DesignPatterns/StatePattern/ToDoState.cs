using System;

namespace DesignPatterns.StatePattern
{
	public class ToDoState : ScrumBoardState
	{
		public ToDoState(Task task) : base(task){}

		public override void SetToDo()
		{
			task.Message = @"Task is already To Do";
		}

		public override void SetInProgress()
		{
			task.Message = @"Task In Progress";
			task.SetState(task.GetInProgressState());
		}

		public override void SetDone()
		{
			task.Message = @"Task cannot be set to Done";
		}
	}
}

