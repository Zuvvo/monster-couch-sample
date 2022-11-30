using UnityEngine;
using UnityEngine.UI;

namespace MonsterCouch.Menu
{
    public class UiMainMenuManager : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _exitButton;

        private MainMenuController _menuController;

        public void Init(MainMenuController menuController)
        {
            _menuController = menuController;

            _playButton.onClick.AddListener(_menuController.StartGame);
            _settingsButton.onClick.AddListener(_menuController.OpenSettings);
            _exitButton.onClick.AddListener(_menuController.ExitGame);
        }
    }

}