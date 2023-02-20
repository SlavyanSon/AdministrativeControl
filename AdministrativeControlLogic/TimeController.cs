namespace AdministrativeControlLogic
{
	public class TimeController
	{
		private readonly int IdleTime = 1 * 1000;

		private int _UserActiveSeconds;

		/// <summary>
		/// Возвращает признак неактивности пользователя.
		/// </summary>
		public bool IsUserIdle => IdleTimeFinder.GetIdleTime() > IdleTime;

		public int UserActiveSeconds => _UserActiveSeconds;

		public void Runner()
		{
			while (true)
			{
				Thread.Sleep(1000);
				if (IsUserIdle == false)
					_UserActiveSeconds++;
			}
		}
	}
}