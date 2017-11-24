using UnityEngine;

namespace Assets.Scripts
{
    public class Equippable : MonoBehaviour
    {
        public float PickupDistance = 2f;
        public Vector3 PickupOffset;
        public Vector3 PickupRotation;

        public bool SupressDebug = true;

        private Transform _player;

        void Start()
        {
            _player = GameObject.Find("Player").transform.root;
        }

        void Update()
        {
            if (transform.parent == null && Input.GetMouseButtonDown(1) && Vector3.Distance(transform.position, _player.position) < PickupDistance)
            {
                var hand = FindObjectOfType<RightHand>();
                hand.Hold(transform, PickupOffset, PickupRotation);
            }
        }
    }
}