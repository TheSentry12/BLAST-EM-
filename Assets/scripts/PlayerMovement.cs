 
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

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
    }
}

