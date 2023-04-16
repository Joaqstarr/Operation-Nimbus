using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public static int _hp = 3;
    [SerializeField]
    TubeScript[] tubes;
    public delegate void  PlayerDied();
    public static PlayerDied playerDied;

    [SerializeField]
    UnityEvent _onHit;
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
        _onHit.Invoke();
        if (_hp <= 0)
        {
            playerDied();
            return;
        };
        bool isPicked = false;
        TubeScript pickedTube = null;
        while (!isPicked)
        {

            int ranPipe = Random.Range(0, tubes.Length );
            if (tubes[ranPipe]._broken == false)
            {
                pickedTube = tubes[ranPipe];
                isPicked = true;
            }
        }

        pickedTube.BreakTube();
        
    }
}
