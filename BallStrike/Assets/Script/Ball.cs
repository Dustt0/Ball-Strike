using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Ball : MonoBehaviour
{
    
    public float cnt = 0;
    public GameManager gm;
    public AudioClip ping;
    public AudioClip thud;
    public AudioClip crack;
    public AudioClip dead;

    // Start is called before the first frame update
    private AudioSource sfx;
    Rigidbody2D rb;
    public float Speed = 6f;
    //private void Awake()
    //{
        
    //    Vector2 startDirection = GetRandomDirection();
    //    rb.velocity = moveSpeed * startDirection;
    //}

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sfx = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (cnt == 0)
        {

            Vector2 startDirection = GetRandomDirection();
            rb.velocity = Speed * startDirection;
            cnt++;

        }
    }
    private Vector2 GetRandomDirection()
    {
        int xDir = Random.Range(0, 2);
        xDir = xDir == 0 ? -1 : 1;
        float yDir = Random.Range(0f, 1f);
        return new Vector2(xDir, yDir);
    }

    //public void Respawn()
    //{

    //    transform.position = new Vector2(-0.033f, -3.34f);

    //    GetComponent<Rigidbody2D>().velocity = Random.insideUnitSphere.normalized * Speed;
    //    Debug.Log(GetComponent<Rigidbody2D>().velocity);
    //}

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "DeadBar")
        {
            FindObjectOfType<GameManager>().GameOver();
            sfx.clip = dead;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Wall")
        {
            
            sfx.clip = thud;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Paddle")
        {
           
            sfx.clip = thud;
            sfx.Play();
        }
        if (collisionInfo.collider.tag == "Brick")
        {
            sfx.clip = crack;
            sfx.Play();
        }
        if (collisionInfo.gameObject.name == "Wall1")
        {
            float SpeedInYDirection = 0f;

            if (rb.velocity.y > 0)

                SpeedInYDirection = 5f;

            if (rb.velocity.y < 0)

                SpeedInYDirection = -5f;

            rb.velocity = new Vector2(3f, SpeedInYDirection/*, 0*/);
        }

        if (collisionInfo.gameObject.name == "Wall1(1)")
        {
            float SpeedInYDirection = 0f;

            if (rb.velocity.y > 0)

                SpeedInYDirection = 5f;

            if (rb.velocity.y < 0)

                SpeedInYDirection = -5f;

            rb.velocity = new Vector2(-3f, SpeedInYDirection/*, 0*/);
        }

        if (collisionInfo.gameObject.name == "UpperBound")
        {
            float SpeedInXDirection = 0f;

            if (rb.velocity.x > 0)

                SpeedInXDirection = 5f;

            if (rb.velocity.x < 0)

                SpeedInXDirection = -5f;

            rb.velocity = new Vector2(SpeedInXDirection, -3f/*, 0*/);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Gem"))
        {
            sfx.clip = ping;
            sfx.Play();
            gm.UpdateScore();
            Destroy(collision.gameObject);
        }
    }
   

}
