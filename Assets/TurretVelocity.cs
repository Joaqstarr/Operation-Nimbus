using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretVelocity : MonoBehaviour
{
    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGrab()
    {
        _rb.constraints = RigidbodyConstraints.None;

    }

    public void OnLetGo()
    {
        _rb.angularVelocity = Vector3.zero;
        _rb.velocity = Vector3.zero;
        _rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}
