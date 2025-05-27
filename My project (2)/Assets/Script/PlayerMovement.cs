using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    float bounds = 5.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        
        
    }
    void Move()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float newPositionX = transform.position.x + speed * xInput * Time.deltaTime;

        if (newPositionX < bounds && newPositionX > -bounds)
        {
            transform.position += new Vector3(speed * xInput * Time.deltaTime, 0f, 0f);
            
        }
    }
}
