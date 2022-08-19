using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.UIControllers;
using UnityEngine.UI;
using DynamicBox.DataContainer;

namespace DynamicBox.UIViews
{
	public class PlayerLoginView : MonoBehaviour
	{
		[SerializeField] private PlayerLoginController controller;

		[SerializeField] private InputField playerNameInputField;

		[SerializeField] private InputField playerNickNameInputField;

		[SerializeField] private GameObject loginPanel;

		[SerializeField] private GameObject playerDataPanel;

		[SerializeField] private Text nameText;

		[SerializeField] private Text nicknameText;

		[SerializeField] private Text healthText;

		[SerializeField] private Text expText;

		public void OnLoginButtonPressed()
		{
			controller.OnLoginButtonPressed(playerNameInputField.text, playerNickNameInputField.text);
		}

		public void SetupPlayerData(PlayerData playerData)
		{
			loginPanel.SetActive(false);

			playerDataPanel.SetActive(true);

			nameText.text = playerData.playerName;

			nicknameText.text = playerData.playerNickName;

			healthText.text = playerData.playerHealth.ToString();

			expText.text = playerData.playerExperience.ToString();
		}
	}
}

