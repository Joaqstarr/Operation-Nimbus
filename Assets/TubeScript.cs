using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeScript : MonoBehaviour
{
    public bool _broken = false;
    // Start is called before the first frame update
    void Start()
    {
        _broken = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreakTube()
    {
        GetComponentInChildren<ParticleSystem>().Play();
        _broken = true;
    }
    private void OnTriggerEnter(Collider collision)
    {
        GetComponentInChildren<ParticleSystem>().Stop();
        _broken = true;
    }

}
