using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrust = 10f;
    public float LandingTime;
    bool isGrounded = false;
    public GameObject Flame;
    public GameObject LandingPoint;
    public float horizontalThrust = 10f;
    public float maxHorizontalSpeed = 8f;
    public float LandingTimeX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        LandingTimeX = Mathf.Abs(LandingPoint.transform.position.x - transform.position.x) / Mathf.Abs(rb.linearVelocity.x);
        LandingTime = transform.position.y / rb.linearVelocity.magnitude;
        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(transform.up * thrust);
        }
        if (LandingTime < 3 && isGrounded == false) 
        {
            rb.AddForce(transform.up * thrust);
                Flame.SetActive(true);
        }
        if (transform.position.y < 1.1) 
        { 
        isGrounded = true;
            Flame.SetActive(false);
        }
        if (LandingTimeX > 1 || LandingTimeX < 1)
        {
            if (isGrounded == false)
                LandingManeuver();
        }
    }
    void LandingManeuver() 
    {
        float xOffset = LandingPoint.transform.position.x - transform.position.x;
        float desiredVelocityX = Mathf.Clamp(xOffset, -maxHorizontalSpeed, maxHorizontalSpeed);
        float velocityError = desiredVelocityX - rb.linearVelocity.x;
        float controlForce = velocityError * horizontalThrust;
        rb.AddForce(Vector2.right * controlForce);
    }
}
