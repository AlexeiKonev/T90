using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    [SerializeField] private Transform _gun;
    [SerializeField] private GameObject _bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(_bullet, _gun.position, _gun.transform.rotation);
        }
    }
}
