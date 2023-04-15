using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRain : MonoBehaviour
{
    [SerializeField]
    float _damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           // Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>()._health -= Time.deltaTime * _damage;
        }
    }
}
