using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missiles : MonoBehaviour
{
    // Start is called before the first frame update
    public float endTranslationPostionY;
    public float speed;

   

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);

        if(transform.position.y > endTranslationPostionY ) 
        {
            Destroy(gameObject);
        }
    }
}
