using System;

namespace DesignPatterns.StatePattern
{
	public class Task
	{
		private ScrumBoardState _toDoState;
		private ScrumBoardState _inProgressState;
		private ScrumBoardState _doneState;

		private ScrumBoardState _taskState;

		public string Name{ get; set; }

		public Task()
		{
			_toDoState = new ToDoState(this);
			_inProgressState = new InProgressState(this);
			_doneState = new DoneState(this);

			_taskState = _toDoState;
		}

		public void SetState(ScrumBoardState state)
		{
			_taskState = state;
		}

		public void SetToDo()
		{
			_taskState.SetToDo();
		}

		public ScrumBoardState GetToDoState()
		{
			return _toDoState;
		}

		public ScrumBoardState GetInProgressState()
		{
			return _inProgressState;
		}

		public ScrumBoardState GetDoneState()
		{
			return _doneState;
		}

		public void SetInProgress()
		{
			_taskState.SetInprogress();
		}

		public void SetDone()
		{
			_taskState.SetDone();
		}

	}
}

