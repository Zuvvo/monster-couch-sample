using System;
using MonsterCouch.Player;
using UnityEngine;

namespace MonsterCouch.AI
{
    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] private EnemyMovement _enemyMovement;

        private PlayerObjectController _player;
        public void Init(PlayerObjectController player, Camera cam)
        {
            _player = player;

            _enemyMovement.Init(_player, cam);
        }

        public void MoveAwayFromPlayerTick()
        {
            _enemyMovement.MoveAwayFromPlayer();
        }
    }

}