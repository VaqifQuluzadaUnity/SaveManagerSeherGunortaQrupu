using DynamicBox.EventManagement;


namespace DynamicBox.UIEvents
{
	public class OnLoginButtonPressedEvent : GameEvent
	{
		public string Name;

		public string NickName;

		public OnLoginButtonPressedEvent(string _name, string _nickName)
		{
			Name = _name;

			NickName = _nickName;
		}

	}
}

