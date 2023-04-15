using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crank : MonoBehaviour
{
    [SerializeField]
    float _deltaRot = 0;
    [SerializeField]
    float _speed = 0.01f;
    float lastRot;
    public float _distanceSpun = 0;
    bool _flop = true;
    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _distanceSpun = _rb.angularVelocity.x * Time.deltaTime * _speed;

    }

    public void ResetSpun()
    {
        _distanceSpun = 0;
    }
}
