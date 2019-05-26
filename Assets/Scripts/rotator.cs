using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rot = 1;
    public float x, y, z = 1;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * rot);  
    }
}
