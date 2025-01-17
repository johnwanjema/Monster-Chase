using UnityEngine;

public class Monster : MonoBehaviour
{

    public  float speed;
    private Rigidbody2D mybody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mybody =  GetComponent<Rigidbody2D>();

        speed = 7f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // velocity as a force to move player up
        // move enemy on the x- axis 
        mybody.linearVelocity = new Vector2(speed,mybody.linearVelocity.y);
    }
}
