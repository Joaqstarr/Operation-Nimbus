using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPitch : MonoBehaviour
{
    [SerializeField]
    float _defaultPitch = 0.6f;
    [SerializeField]
    float _hitPitch = 3f;
    [SerializeField]
    float _speed = 5;


    float _targPitch;

    AudioSource _source;
    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
        _defaultPitch = _source.pitch;
        _targPitch = _defaultPitch;
    }

    // Update is called once per frame
    void Update()
    {
        _source.pitch = Mathf.Lerp(_source.pitch, _targPitch, Time.deltaTime * _speed);

    }

    public void OnGrab()
    {
        _targPitch = _hitPitch;
    }
    public void OnLetGo()
    {
        _targPitch = _defaultPitch;
    }
}
