using UnityEngine;
using MonsterCouch.AI;
using MonsterCouch.Player;
using MonsterCouch.Settings;

namespace MonsterCouch
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private PlayerObjectController _playerObjectControllerPrefab;
        [SerializeField] private EnemiesController _enemiesController;
        [SerializeField] private GameSettings _settings;
        private Camera _mainCamera;

        private PlayerObjectController _playerInstance;

        private void Awake()
        {
            _mainCamera = Camera.main;

            _playerInstance = Instantiate(_playerObjectControllerPrefab);
            _playerInstance.Init(_mainCamera);

            _enemiesController.Init(_settings.EnemiesCount);
        }
    }
}