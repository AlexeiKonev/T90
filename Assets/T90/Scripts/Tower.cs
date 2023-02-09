using UnityEngine;

public class Tower : MonoBehaviour {
    [SerializeField] private float _mouseSens;
    [SerializeField] private Transform _tankTower;
    [SerializeField] private float _xRotation = 0f;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSens * Time.deltaTime;

        _tankTower.Rotate(Vector3.up * mouseX);
    }
}
