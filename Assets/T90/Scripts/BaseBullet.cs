using UnityEngine;

public abstract class BaseBullet : MonoBehaviour {
    [SerializeField] private float _speed = 30f;
    [SerializeField] private Rigidbody _rb;
    protected void Awake() {
        _rb = GetComponent<Rigidbody>();
    }
    protected void FixedUpdate() {
        _rb.AddForce(transform.forward * _speed);
    }
    protected void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("popal collider");
        }
    }
    protected void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemy") {
            Debug.Log("popal triger");
        }
    }

}
