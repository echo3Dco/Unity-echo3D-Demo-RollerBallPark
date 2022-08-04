using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls the ball's ongoing velocity
public class BallVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 ballSpeed;

    void FixedUpdate()
    {
        // Sets movement on x axis and adds it to existing speed within the FixedUpdate so it's consistent 
        GetComponent<Rigidbody>().velocity += ballSpeed;
    }
}
