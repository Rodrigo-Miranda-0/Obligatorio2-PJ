using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLoop : MonoBehaviour
{
    public float scrollSpeed = 3.5f;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
        if(transform.position.y < -25f)
        {
            transform.position = new Vector3(16, 55f, 0);
        }
    }
}
