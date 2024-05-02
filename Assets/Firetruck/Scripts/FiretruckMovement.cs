using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiretruckMovement : MonoBehaviour
{ 

    public float speed = 5f;

    private Vector3 endPosition = new Vector3(-1, 0, 0);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = transform.position;

        if (moveVector.x > endPosition.x)
        {
            moveVector.x = moveVector.x + (-speed * Time.deltaTime);
        }

        transform.position = moveVector;
    }
}
