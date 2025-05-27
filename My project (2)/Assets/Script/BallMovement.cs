using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private Vector2 launchForce;

    private bool hasLaunched = false; // Bandera para controlar si ya fue lanzada
    // Start is called once before th<e first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Si la pelota no ha sido lanzada aún y el jugador presiona el botón "Launch"
        if (!hasLaunched && Input.GetButtonDown("Launch")) {
            rb.AddForce(launchForce);
            transform.parent = null;
            hasLaunched = true; // Marcar como lanzada
        }

    }
}
