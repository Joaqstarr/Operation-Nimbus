using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPitchController : MonoBehaviour
{
    [SerializeField]
    float _defaultPitch = 1;
    [SerializeField]
    float _hitPitch = 0.9f;
    [SerializeField]
    float _speed = 1;
    [SerializeField]
    float _threshold = 0.01f;

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
        if(Mathf.Abs(_source.pitch - _hitPitch) < _threshold)
        {
            _targPitch = _defaultPitch;
        }
    }

    public void OnHit()
    {
        _targPitch = _hitPitch;
    }
}
