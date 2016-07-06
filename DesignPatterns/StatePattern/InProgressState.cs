using System;

namespace DesignPatterns.StatePattern
{
	public class InProgressState : ScrumBoardState
	{
		public InProgressState(Task task) : base(task){}

		public override void SetToDo()
		{
			task.Message = @"To Do";
			task.SetState(task.GetToDoState());
		}

		public override void SetInProgress()
		{
			task.Message = @"Task is already In Progress";
		}

		public override void SetDone()
		{
			task.Message = @"Task Done";
			task.SetState(task.GetDoneState());
		}

	}
}

