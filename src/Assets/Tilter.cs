﻿using UnityEngine;

namespace Assets
{
    public class Tilter : MonoBehaviour
    {
        public float MaxTilt = 2;
        public float TiltSpeed = 1f;

        private float _currentTilt;

        void Update()
        {
            var sideMovemnt = Input.GetAxisRaw("Horizontal");
            var tilt = -1 * sideMovemnt * MaxTilt;

            _currentTilt = _currentTilt.MoveTowards(tilt, TiltSpeed);

            var rot = transform.localRotation;
            transform.localRotation = Quaternion.AngleAxis(_currentTilt, Vector3.forward);
        }
    }
}