using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fueselage : MonoBehaviour
{
    Health _playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = GameObject.Find("HealthManager").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<EnemyHealth>()._health <= 0) return;
            collision.gameObject.GetComponent<EnemyHealth>().Explode();
            _playerHealth.Damage();
        }
    }
}
