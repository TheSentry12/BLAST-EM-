 using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 5;
    public float rotSpeed = 360;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        quaternion rot = transform.rotation;
        float z = rot.EulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
       
        rot = quaternion.Euler(0 ,0, z);
        
        transform.rotation = rot;
        
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        pos += velocity;

        transform.position = pos;
    }
}
