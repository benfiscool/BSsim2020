using UnityEngine;

public class KeyboardMovement : MonoBehaviour {
    private Animator _animator;
    private float MoveSpeed = 1.5f;
    
	void Start () {
        _animator = GetComponent<Animator>();
	}
    
    void Update() {
        var forward = Input.GetAxisRaw("Vertical");
        var sideways = Input.GetAxisRaw("Horizontal");

        _animator.SetFloat("Vertical", forward);
        _animator.SetFloat("Horizontal", sideways);

        if (forward != 0 || sideways != 0)
        {
            transform.Translate(sideways * MoveSpeed * Time.deltaTime, 0, forward * MoveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.enabled = !_animator.enabled;
        }
	}
}
