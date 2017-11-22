using UnityEngine;

namespace Assets.Scripts
{
    public class RightHand : MonoBehaviour
    {
        private Rigidbody _held;

        void Update()
        {
            if (_held == null)
            {
                _held = GetComponentInChildren<Rigidbody>();
            }

            if (Input.GetMouseButtonDown(0))
            {
                _held.isKinematic = false;
                _held.AddForce(Camera.main.transform.forward * 500);
                _held.transform.parent = null;
            }
        }
    }
}