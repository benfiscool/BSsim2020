using UnityEngine;

public class MouseTurning : MonoBehaviour {
    public float MouseSensetivity = 10f;
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
        var horizontalTurn = Input.GetAxis("Mouse X") * MouseSensetivity * Time.deltaTime;
        transform.Rotate(0, horizontalTurn, 0);
    }
}
