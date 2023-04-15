using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHover()
    {
        Debug.Log("hovered");
    }
    public void OnSelect()
    {
        Debug.Log("Selected");
    }
}
