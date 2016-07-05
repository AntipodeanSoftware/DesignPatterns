using System;

namespace DesignPatterns.StatePattern
{
	public class DoneState : ScrumBoardState
	{
		public DoneState(Task task) : base(task){}

		public override void SetToDo()
		{
			Message = @"Task cannot go from Done to To Do";
		}

		public override void SetInProgress()
		{
			task.SetState(task.GetInProgressState ());
			Message = @"Task In Progress";
		}

		public override void SetDone()
		{
			Message = @"Task is already Done";
		}
	}
}

