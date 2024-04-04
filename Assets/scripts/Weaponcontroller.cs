using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public Transform missleTransform;

    // Update is called once per frame
    void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(prefab, missleTransform.position, quaternion);
        }
    }
}
