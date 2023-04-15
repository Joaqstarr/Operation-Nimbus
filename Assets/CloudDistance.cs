using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDistance : MonoBehaviour
{
    [SerializeField]
    float _minDistance = 1;
    [SerializeField]
    float _maxDistance = 1;
    [SerializeField]
    Crank _crank;
    [SerializeField]
    float _speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.Clamp(transform.localPosition.z + (_crank._distanceSpun * Time.deltaTime * _speed), _minDistance, _maxDistance));
    }
}
