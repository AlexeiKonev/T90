using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float _moveSpeed = 10;
    Rigidbody _rb;
    void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetAxis("Vertical") > 0) {
            _rb.AddForce(transform.forward * _moveSpeed);
        }

    }
}
