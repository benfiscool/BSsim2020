using System;
using System.Collections;
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

            if (Input.GetMouseButtonDown(0) && _held != null)
            {
                _held.transform.SetParent(null, true);
                _held.isKinematic = false;
                _held.velocity = Vector3.zero;
                _held.detectCollisions = true;

                var coroutine = WaitASec(() =>
                {
                    _held.AddForce(Camera.main.transform.forward * 10 + Vector3.up * 2, ForceMode.VelocityChange);
                    _held = null;
                });
                StartCoroutine(coroutine);
            }
        }

        public void Hold(Transform t, Vector3 pickupOffset, Vector3 pickupRotation)
        {
            if (_held == null)
            {
                _held = t.GetComponent<Rigidbody>();
                _held.detectCollisions = false;
                _held.isKinematic = true;
                _held.velocity = Vector3.zero;

                var coroutine = WaitASec(() =>
                {
                    t.parent = transform;
                    t.localPosition = pickupOffset;
                    t.localRotation = Quaternion.Euler(pickupRotation);
                    _held.velocity = Vector3.zero;
                });
                StartCoroutine(coroutine);
            }
        }

        public IEnumerator WaitASec(Action a)
        {
            yield return null;
            a();
        }
    }
}