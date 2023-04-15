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
        _hp = tubes.Length;
    }

    // Update is called once per frame
    void Update()
    {
        int progHealth = 0;
        foreach(TubeScript tube in tubes)
        {
            if(tube._broken == false)
            {
                progHealth++;
            }
        }
        _hp = progHealth;
    }
    public void Damage()
    {
        bool isPicked = false;
        TubeScript pickedTube = null;
        while (!isPicked)
        {

            int ranPipe = Random.Range(0, tubes.Length - 1);
            if (tubes[ranPipe]._broken == false)
            {
                pickedTube = tubes[ranPipe];
                isPicked = true;
            }
        }

        pickedTube.BreakTube();
        
    }
}
