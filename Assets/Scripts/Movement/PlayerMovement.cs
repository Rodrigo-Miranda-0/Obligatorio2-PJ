using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W)){
            this.transform.position += Vector3.up * this.speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.S)){
            this.transform.position += Vector3.down * this.speed * Time.deltaTime;
        }

        if(transform.position.x >= 2.3f)
        {
            transform.position = new Vector3(2.3f, transform.position.y, 0);
        }else if(transform.position.x <= -2.3f)
        {
            transform.position = new Vector3(-2.3f, transform.position.y, 0);
        }

        if(transform.position.y <= -4.65f)
        {
            transform.position = new Vector3(transform.position.x, -4.65f, 0);
        }else if(transform.position.y >= 4.50f)
        {
            transform.position = new Vector3(transform.position.x, 4.50f, 0);
        }
    }
}
