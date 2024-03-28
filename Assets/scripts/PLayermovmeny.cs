using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayermovmeny : MonoBehaviour
{
    float maxSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Returns a FLOAT from -1.0 to +1.0
        

        Vector3 pos = transform.position;
       
        pos.y += Input.GetAxis("Vertical");
        
        transform.position = pos;



    }
}
