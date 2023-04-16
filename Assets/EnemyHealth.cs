using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class EnemyHealth : MonoBehaviour
{
    public float _health = 10;
    [SerializeField]
    ParticleSystem[] _systems;
    float _maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        _maxHealth = _health;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<_systems.Length; i++)
        {
            //     _systems[i].main. startLifetimeMultiplier = _health;
            var main = _systems[i].main;
            main.startLifetimeMultiplier = _health / _maxHealth;
        }

        if(_health < 0)
        {
            GetComponent<EnemyPathfinding>().enabled = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(1, -4, 0), ForceMode.Impulse);
            GetComponent<Rigidbody>().AddTorque(new Vector3(-30, 0, 50), ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 3);
           // GetComponent<CapsuleCollider>().enabled = false;
            Destroy(this);
        }

    }
}
