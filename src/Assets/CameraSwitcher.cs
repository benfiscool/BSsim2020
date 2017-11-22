using UnityEngine;

namespace Assets
{
    public class CameraSwitcher : MonoBehaviour
    {
        public Camera FirstPersonCamera;

        public Camera ThirdPersonCamera;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                FirstPersonCamera.enabled = true;
                ThirdPersonCamera.enabled = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket))
            {
                FirstPersonCamera.enabled = false;
                ThirdPersonCamera.enabled = true;
            }
        }
    }
}