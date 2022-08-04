using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls the ball's velocity
public class BallController : MonoBehaviour
{
    [SerializeField]
    Vector3 ballSpeed;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
        {
            // Adds force to existing speed within the FixedUpdate so movement is consistent
            GetComponent<Rigidbody>().velocity += ballSpeed;
        }

        if (Input.GetKey(keyNegative))
        {
            // Lessens force to existing speed within the FixedUpdate so movement is consistent
            GetComponent<Rigidbody>().velocity -= ballSpeed;
        }
    }
}
