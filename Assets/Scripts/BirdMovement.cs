using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public bool isAlive = true;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    public GameObject DeathScreen;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Havada kuşun zıplamasını sağlar
            rb2D.linearVelocity = Vector2.up * velocity;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isAlive = false;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }
}
