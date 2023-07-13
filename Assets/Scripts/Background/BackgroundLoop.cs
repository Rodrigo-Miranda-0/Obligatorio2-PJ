using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float scrollSpeed = 3f;
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
            transform.position = startPosition;
        }
    }
}
