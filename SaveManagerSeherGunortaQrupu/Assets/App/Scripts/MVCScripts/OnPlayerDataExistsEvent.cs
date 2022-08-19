using DynamicBox.DataContainer;
using DynamicBox.EventManagement;

public class OnPlayerDataExistsEvent : GameEvent
{
  public PlayerData PlayerData;

	public OnPlayerDataExistsEvent(PlayerData _playerData)
	{
		PlayerData = _playerData;
	}
}
