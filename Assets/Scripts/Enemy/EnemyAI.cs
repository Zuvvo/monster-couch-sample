using System;
using MonsterCouch.Player;
using UnityEngine;

namespace MonsterCouch.AI
{
    public class EnemyAI : MonoBehaviour
    {
        public int Id { get; private set; }

        [SerializeField] private EnemyMovement _enemyMovement;

        private PlayerObjectController _player;
        
        public event Action<int> OnPlayerTouched;

        public void Init(int id, PlayerObjectController player, Camera cam)
        {
            Id = id;
            _player = player;

            _enemyMovement.Init(this, _player, cam);
        }

        public void MoveAwayFromPlayerTick()
        {
            _enemyMovement.MoveAwayFromPlayer();
        }

        public void CallOnPlayerTouched()
        {
            OnPlayerTouched.Invoke(Id);
        }
    }
}