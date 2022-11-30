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

        private List<EnemyAI> _enemies = new List<EnemyAI>();

        public void Init(int enemiesCount, PlayerObjectController player, Camera cam, Vector2 spawnOffset)
        {
            for (int i = 0; i < enemiesCount; i++)
            {
                Vector3 pos = new Vector3(UnityEngine.Random.Range(-spawnOffset.x, spawnOffset.x), UnityEngine.Random.Range(-spawnOffset.y, spawnOffset.y), 0);
                EnemyAI enemy = Instantiate(_enemyAiPrefab, pos, Quaternion.identity);
                enemy.Init(player, cam);
                _enemies.Add(enemy);
            }
            IsInitialized = true;
        }

        private void Update()
        {
            MoveEnemies();
        }

        private void MoveEnemies()
        {
            if (IsInitialized)
            {
                for (int i = 0; i < _enemies.Count; i++)
                {
                    _enemies[i].MoveAwayFromPlayerTick();
                }
            }
        }
    }
}