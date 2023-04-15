using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    GameObject _target;
    [SerializeField]
    float speed;
    float flyingspeed = 0;
    [SerializeField]
    float flyingAccel = 1;
    [SerializeField]
    float _planeSpeed = 10f;
    private void Start()
    {

        _target = GameObject.Find("Fueselage");
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //rb.AddForce(new Vector3(0, 0, _planeSpeed), ForceMode.Force);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.yellow, 1f);
        Debug.DrawRay(transform.position, transform.right * 2, Color.blue, 1f);
        Debug.DrawRay(transform.position, transform.up * 2, Color.green, 1f);

        flyingspeed += Time.deltaTime * flyingAccel;
        rb.velocity = (transform.forward * flyingspeed)+ new Vector3(0, 0, _planeSpeed);

        //Now Turn the Rocket towards the Target
        var rocketTargetRot = Quaternion.LookRotation(_target.transform.position - transform.position, transform.up);
        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rocketTargetRot, speed));
    }
 
}
