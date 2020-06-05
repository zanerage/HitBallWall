using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    public float bounceForce;

    bool gameStarted;
  


    private void Awake() {
        myrigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if(!gameStarted) {
            if(Input.anyKeyDown) {
            StartBounce();
            gameStarted = true;
           GameManager.instance.GameStart();
        }
    }
          
}

    public void StartBounce() {
        Vector2 randomDirection = new Vector2(Random.Range(-1,1),1);
        myrigidbody.AddForce(randomDirection * bounceForce,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "GameOver") {
            GameManager.instance.Restart();
        }
        else if(other.gameObject.tag == "Paddle") {
            GameManager.instance.ScoreUp();
        }

    }

    
}
