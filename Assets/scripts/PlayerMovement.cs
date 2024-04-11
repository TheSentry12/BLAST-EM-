 
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public int eneminesKilled;

    private void Awake()
    {
        
    }

    private void Start()
    {
   
        Debug.Log(speed);
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        // Debug.Log(direction);
        transform.Translate(speed * Time.deltaTime * new Vector2(horizontalDirection, verticalDirection));

        if (eneminesKilled >= 10)
        {
            SceneManager.LoadScene(2);
        }
    }
}

