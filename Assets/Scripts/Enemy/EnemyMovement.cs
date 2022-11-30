using UnityEngine;
using MonsterCouch.Player;
using MonsterCouch.Constants;
using MonsterCouch.Utilities;

namespace MonsterCouch.AI
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private PlayerObjectController _player;
        private Camera _cam;
        private EnemyAI _enemyAI;

        public void Init(EnemyAI enemyAI, PlayerObjectController player, Camera cam)
        {
            _enemyAI = enemyAI;
            _player = player;
            _cam = cam;
        }

        public void MoveAwayFromPlayer()
        {
            float deltaTime = Time.deltaTime;
            Vector3 moveDirection = (transform.position - _player.transform.position).normalized;
            Vector3 translationVec = new Vector3(_speed * deltaTime * moveDirection.x, _speed * deltaTime * moveDirection.y, 0);

            Vector3 newPos = transform.position + translationVec;

            if (ScreenUtilities.IsWorldPosInsideScreenRange(_cam, newPos))
            {
                transform.Translate(translationVec);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(TagConstants.Player))
            {
                _enemyAI.CallOnPlayerTouched();
            }
        }
    }
}