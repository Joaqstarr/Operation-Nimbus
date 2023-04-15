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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = transform.eulerAngles.x - lastRot;
        Debug.Log(transform.eulerAngles.x);

        if (angle > 180) angle -= 360;
        if (angle < -180) angle += 360;
        _deltaRot = angle;
        _distanceSpun += _deltaRot * _speed * Time.deltaTime;
        lastRot = transform.eulerAngles.x;
    }

    public void ResetSpun()
    {
        _distanceSpun = 0;
    }
}
