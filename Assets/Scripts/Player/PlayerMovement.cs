using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MonsterCouch.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public bool IsInitialized { get; private set; }
        [SerializeField] private float _speed;


        public void Init()
        {
            IsInitialized = true;
        }

        void Update()
        {
            if (IsInitialized)
            {
                float horizontalMovement = Input.GetAxis("Horizontal");
                float verticalMovement = Input.GetAxis("Vertical");

                transform.Translate(new Vector3(_speed * horizontalMovement, _speed * verticalMovement, 0));
            }
        }
    }

}