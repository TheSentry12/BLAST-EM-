using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        health -= 1;
    }

    public int GetHealth()
    {
        return health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("collide");
        if (collision != null && collision.gameObject.CompareTag("Enemy"))
        {

            //Destroy(this.gameObject);
            //Destroy(collision.gameObject);
            SceneManager.LoadScene(2);


        }
       
        
    }
        
}

