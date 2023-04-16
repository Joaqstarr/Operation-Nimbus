using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudColor : MonoBehaviour
{
    [SerializeField]
    Vector4 _closeColor;
    [SerializeField]
    Vector4 _farColor;
    CloudDistance _distance;
    [SerializeField]
    MeshRenderer _tintRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _distance = GetComponent<CloudDistance>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(_tintRenderer.materials[0].GetVector("_TintColor"));
        _tintRenderer.materials[0].SetVector("_TintColor", Vector4.Lerp(_closeColor, _farColor, _distance._distanceRatio));
    }
}
