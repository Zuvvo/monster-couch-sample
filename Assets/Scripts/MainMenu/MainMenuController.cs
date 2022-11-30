using UnityEngine;
using UnityEngine.SceneManagement;
using MonsterCouch.Constants;

namespace MonsterCouch.Menu
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private UiMainMenuManager _uiMainMenuManager;
        [SerializeField] private UiMenuSettingsManager _uiMenuSettingsManager;

        private void Start()
        {
            _uiMainMenuManager.Init(this);
            _uiMenuSettingsManager.Init(this);
        }

        public void StartGame()
        {
            SceneManager.LoadScene(SceneNames.GameScene);
        }

        public void OpenSettings()
        {
            _uiMenuSettingsManager.Open();
        }

        public void CloseSettings()
        {
            _uiMenuSettingsManager.Close();
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }

}