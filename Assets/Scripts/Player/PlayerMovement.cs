using UnityEngine;
using MonsterCouch.Utilities;

namespace MonsterCouch.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public bool IsInitialized { get; private set; }
        [SerializeField] private float _speed;
        private Camera _cam;


        public void Init(Camera cam)
        {
            _cam = cam;
            IsInitialized = true;
        }

        void Update()
        {
            if (IsInitialized)
            {
                float horizontalMovement = Input.GetAxis("Horizontal");
                float verticalMovement = Input.GetAxis("Vertical");
                float deltaTime = Time.deltaTime;

                Vector3 translationVec = new Vector3(_speed * deltaTime * horizontalMovement, _speed * deltaTime * verticalMovement, 0);

                Vector3 newPos = transform.position + translationVec;

                if (ScreenUtilities.IsWorldPosInsideScreenRange(_cam, newPos))
                {
                    transform.Translate(translationVec);
                }
            }
        }
    }
}