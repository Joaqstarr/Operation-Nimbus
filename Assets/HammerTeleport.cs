using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTeleport : MonoBehaviour
{
    public Transform _resetPos;
    Rigidbody _rb;
    //Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        gameObject.transform.position = _resetPos.position;
        _rb.velocity = Vector3.zero;
        transform.eulerAngles = _resetPos.eulerAngles;
    }

    //Update is called once per frame
    public void ResetPosition()
    {
        gameObject.transform.position = _resetPos.position;
        _rb.velocity = Vector3.zero;
        transform.eulerAngles = _resetPos.eulerAngles;
    }
}
