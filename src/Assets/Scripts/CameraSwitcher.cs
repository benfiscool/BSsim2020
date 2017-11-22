using UnityEngine;

namespace Assets.Scripts
{
    public class CameraSwitcher : MonoBehaviour
    {
        public Camera FirstPersonCamera;
        public Camera ThirdPersonCamera;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                FirstPersonCamera.gameObject.SetActive(true);
                ThirdPersonCamera.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket))
            {
                FirstPersonCamera.gameObject.SetActive(false);
                ThirdPersonCamera.gameObject.SetActive(true);
            }
        }
    }
}