using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeScript : MonoBehaviour
{
    public bool _broken = false;
    [SerializeField]
    AudioSource _hammerSource;
    [SerializeField]
    AudioSource _steamSource;
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
        _steamSource.Play();

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (!_broken) return;
        _steamSource.Stop();
        _hammerSource.Play();
        GetComponentInChildren<ParticleSystem>().Stop();
        _broken = false;
    }

}
