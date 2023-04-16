using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CloudRain : MonoBehaviour
{
    [SerializeField]
    float _damage = 2;
    [SerializeField]
    UnityEvent StartHit;
    [SerializeField]
    UnityEvent EndHit;
    XRBaseController _lCont;
    XRBaseController _rCont;
    // Start is called before the first frame update
    void Start()
    {
        _lCont = GameObject.Find("LeftController").GetComponent<XRBaseController>();
        _rCont = GameObject.Find("RightController").GetComponent<XRBaseController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            StartHit.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EndHit.Invoke();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if(enemyHealth != null)
            {
                enemyHealth._health -= Time.deltaTime * _damage;
                _lCont.SendHapticImpulse(0.4f, 0.1f);
                _rCont.SendHapticImpulse(0.4f, 0.1f);

            }

        }
    }
}
