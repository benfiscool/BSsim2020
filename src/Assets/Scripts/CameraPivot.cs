using UnityEngine;

namespace Assets
{
    public class CameraPivot : MonoBehaviour
    {
        public float MouseSensetivity = 80f;
        public float Rotation = 25;

        void Update()
        {
            var verticalTurn = Input.GetAxis("Mouse Y") * MouseSensetivity * Time.deltaTime * -1;
            Rotation += verticalTurn;
            Rotation = Mathf.Clamp(Rotation, -90, 90);
            transform.localRotation = Quaternion.AngleAxis(Rotation, Vector3.right);
        }
    }
}