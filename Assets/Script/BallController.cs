using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.name == "greenSquare" || other.collider.name == "Top")
        {
            //rb.velocity = Vector2.zero;
            //rb.angularVelocity = 0f;
            rb.AddForce(new Vector2(Random.Range(-10f, 10f), 15f), ForceMode2D.Impulse);
        }
        
        if(other.collider.name == "Left" || other.collider.name == "Right")
        {
            //rb.velocity = Vector2.zero;
            //rb.angularVelocity = 0f;
            rb.AddForce(new Vector2(10f,Random.Range(-10f, 10f)), ForceMode2D.Impulse);
        }
        if(other.collider.name == "Square(Clone)")
        {
            rb.AddForce(new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)), ForceMode2D.Impulse);
            Score.score++;
            Destroy(other.gameObject);
            
        }
        if(other.collider.name == "Bottom")
        {
            SceneManager.LoadScene("menu");
            Score.score = 0;
        }
        
    }

}