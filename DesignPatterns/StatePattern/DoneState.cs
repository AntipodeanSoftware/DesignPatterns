using System;

namespace DesignPatterns.StatePattern
{
	public class DoneState : ScrumBoardState
	{
		public DoneState(Task task) : base(task){}

		public override void SetToDo()
		{
			Console.WriteLine(String.Format("{0} Cannot go from Done to To Do", base._task.Name));
		}

		public override void SetInProgress()
		{
			Console.WriteLine(String.Format("{0} is In Progress",base._task.Name));
			_task.SetState(_task.GetInProgressState ());
		}

		public override void SetDone()
		{
			Console.WriteLine(String.Format("{0} is already Done", base._task.Name));
		}
	}
}

