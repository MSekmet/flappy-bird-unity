using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public bool isAlive = true;
    public float velocity = 1f;
    public Rigidbody2D rb2D;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Havada kuşun zıplamasını sağlar
            rb2D.linearVelocity = Vector2.up * velocity;
        }
        
    }
}
