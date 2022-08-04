using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ensures ball rotates since we locked constraints on camera as a child
public class BallRoller : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = transTarget.position;
    }
}
