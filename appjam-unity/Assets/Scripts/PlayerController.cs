using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    float movePower = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector2(-movePower, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector2(movePower, 0));
        }


    }
    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.tag == "Foothold"){
            rig.AddForce(transform.up*10.0f,ForceMode2D.Impulse);
        }
    }
}