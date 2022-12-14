using System.Collections.Generic;
using UnityEngine;
using MonsterCouch.Player;
using System;

namespace MonsterCouch.AI
{
    public class EnemiesController : MonoBehaviour
    {
        [SerializeField] EnemyAI _enemyAiPrefab;

        public bool IsInitialized { get; private set; }

        private Dictionary<int, EnemyAI> _moveingEnemies = new Dictionary<int, EnemyAI>();

        public void Init(int enemiesCount, PlayerObjectController player, Camera cam, Vector2 spawnOffset)
        {
            for (int i = 0; i < enemiesCount; i++)
            {
                Vector3 pos = new Vector3(UnityEngine.Random.Range(-spawnOffset.x, spawnOffset.x), UnityEngine.Random.Range(-spawnOffset.y, spawnOffset.y), 0);

                EnemyAI enemy = Instantiate(_enemyAiPrefab, pos, Quaternion.identity);
                enemy.Init(i, player, cam);
                enemy.OnPlayerTouched += Enemy_OnPlayerTouched;

                _moveingEnemies.Add(i, enemy);
            }
            IsInitialized = true;
        }

        private void Enemy_OnPlayerTouched(int id)
        {
            _moveingEnemies[id].OnPlayerTouched -= Enemy_OnPlayerTouched;
            _moveingEnemies.Remove(id);
        }

        private void Update()
        {
            MoveEnemies();
        }

        private void MoveEnemies()
        {
            if (IsInitialized)
            {
                foreach (KeyValuePair<int, EnemyAI> kvp in _moveingEnemies)
                {
                    kvp.Value.MoveAwayFromPlayerTick();

                }
            }
        }
    }
}