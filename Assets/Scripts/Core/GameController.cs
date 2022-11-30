using UnityEngine;
using MonsterCouch.AI;
using MonsterCouch.Player;
using MonsterCouch.Settings;

namespace MonsterCouch
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] PlayerObjectController _playerObjectControllerPrefab;
        [SerializeField] EnemiesController _enemiesController;
        [SerializeField] GameSettings _settings;

        private PlayerObjectController _playerInstance;

        private void Awake()
        {
            _playerInstance = Instantiate(_playerObjectControllerPrefab);

            _enemiesController.Init(_settings.EnemiesCount);
        }
    }
}