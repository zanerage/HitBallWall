using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    public float bounceForce;


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
          if(Input.anyKeyDown) {
            StartBounce();
        }
    }

    public void StartBounce() {
        Vector2 randomDirection = new Vector2(Random.Range(-1,1),1);
        myrigidbody.AddForce(randomDirection * bounceForce,ForceMode2D.Impulse);
    }
}
