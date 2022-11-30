using System.Collections.Generic;
using UnityEngine;

namespace MonsterCouch.AI
{
    public class EnemiesController : MonoBehaviour
    {
        [SerializeField] EnemyAI _enemyAiPrefab;

        private List<EnemyAI> _enemies = new List<EnemyAI>();

        public void Init(int enemiesCount)
        {
            for (int i = 0; i < enemiesCount; i++)
            {
                EnemyAI enemy = Instantiate(_enemyAiPrefab);
                _enemies.Add(enemy);
            }
        }
    }
}