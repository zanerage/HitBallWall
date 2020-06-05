using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    public float speed = 7;


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
        
    }

    private void FixedUpdate() {
        TouchMove();
    }

    public void TouchMove() {
        if(Input.GetMouseButton(0)) {
            Vector2 currentPos = this.transform.position;
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPosition.x < currentPos.x) {

                // we are moving left

                myrigidbody.velocity = Vector2.left * speed;

            }
            else {
                // or right

                myrigidbody.velocity = Vector2.right * speed;

            }
        }

        else {
            myrigidbody.velocity = Vector2.zero;
        }
    }
}
