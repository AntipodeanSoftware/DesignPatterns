using System;

namespace DesignPatterns.StatePattern
{
	public class DoneState : ScrumBoardState
	{
		public DoneState(Task task) : base(task){}

		public override void SetToDo()
		{
			task.Message = @"Task cannot go from Done to To Do";
		}

		public override void SetInProgress()
		{
			task.Message = @"Task In Progress";
			task.SetState(task.GetInProgressState ());

		}

		public override void SetDone()
		{
			task.Message = @"Task is already Done";
		}
	}
}

