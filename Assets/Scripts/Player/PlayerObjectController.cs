using UnityEngine;

namespace MonsterCouch.Player
{
    public class PlayerObjectController : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _playerMovement;

        public void Init()
        {
            _playerMovement.Init();
        }
    }
}