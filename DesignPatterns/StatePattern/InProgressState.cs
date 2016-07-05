using System;

namespace DesignPatterns.StatePattern
{
	public class InProgressState : ScrumBoardState
	{
		public InProgressState(Task task) : base(task){}

		public override void SetToDo()
		{
			task.SetState(task.GetToDoState());
			Message = @"To Do";
		}

		public override void SetInProgress()
		{
			Message = @"Task is already In Progress";
		}

		public override void SetDone()
		{
			task.SetState(task.GetDoneState());
			Message = @"Task Done";
		}

	}
}

