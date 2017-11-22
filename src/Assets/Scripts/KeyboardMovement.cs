using UnityEngine;

namespace Assets
{
    public class KeyboardMovement : MonoBehaviour
    {
        private Animator _animator;
        private float MoveSpeed = 1.5f;

        public float JumpForce = 100f;

        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            RaycastHit info;
            Physics.Raycast(transform.position + new Vector3(0, .5f, 0), Vector3.down, out info, 1f, ~(1 << 8));
            _animator.SetBool("IsInMidAir", info.collider == null);

            var forward = Input.GetAxisRaw("Vertical");
            var sideways = Input.GetAxisRaw("Horizontal");

            _animator.SetFloat("Vertical", forward, 1f, Time.smoothDeltaTime * 10f);
            _animator.SetFloat("Horizontal", sideways, 1f, Time.smoothDeltaTime * 10f);

            if (forward != 0 || sideways != 0)
            {
                transform.Translate(sideways * MoveSpeed * Time.deltaTime, 0, forward * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space) && info.collider != null)
            {
                var rb = GetComponentInChildren<Rigidbody>();
                rb.AddForce(Vector2.up * JumpForce);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                _animator.enabled = !_animator.enabled;
            }
        }
    }
}