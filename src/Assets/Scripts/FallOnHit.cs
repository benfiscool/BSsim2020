using UnityEngine;

namespace Assets.Scripts
{
    public class FallOnHit : MonoBehaviour
    {
        public float Breakpoint = 2f;

        private Animator _animator;

        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        void OnCollisionEnter(Collision c)
        {
            if (c.relativeVelocity.magnitude > Breakpoint)
            {
                if (_animator != null)
                {
                    Fall();
                }
                else
                {
                    var p = transform.root.GetComponent<FallOnHit>();
                    if (p != null) { p.Fall(); }
                }
            }
        }

        public void Fall()
        {
            _animator.enabled = false;
        }
    }
}