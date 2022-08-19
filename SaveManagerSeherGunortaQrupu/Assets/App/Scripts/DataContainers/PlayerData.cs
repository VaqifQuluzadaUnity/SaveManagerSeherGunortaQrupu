
namespace DynamicBox.DataContainer
{
	public class PlayerData
	{
		public int playerHealth=100;

		public int playerExperience=0;

		public string playerName;

		public string playerNickName;

		public int[] playerItemHealthArray;

		public PlayerData(string _playerName, string _playerNickName)
		{
			playerName = _playerName;

			playerNickName = _playerNickName;
		}
	}
}

