using System;

namespace DesignPatterns.StatePattern
{
	public class Task
	{
		private ScrumBoardState _toDoState;
		private ScrumBoardState _inProgressState;
		private ScrumBoardState _doneState;

		private ScrumBoardState _taskState;

		public MessageProvider messageProvider;

		string message;

		public string Message { get { return message; } set { message = value; messageProvider.PublishMessage(message); } }

		public string Name{ get; set; }

		public ScrumBoardState CurrentState { get { return _taskState; } }

		public Task()
		{
			messageProvider = new MessageProvider();

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
			_taskState.SetInProgress();
		}

		public void SetDone()
		{
			_taskState.SetDone();
		}

	}
}

