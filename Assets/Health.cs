using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int _hp = 3;
    TubeScript[] tubes;
    // Start is called before the first frame update
    void Start()
    {
        tubes = GetComponentsInChildren<TubeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage()
    {
        tubes[Mathf.Abs(_hp - 3)].BreakTube();
        _hp = _hp - 1;
    }
}
