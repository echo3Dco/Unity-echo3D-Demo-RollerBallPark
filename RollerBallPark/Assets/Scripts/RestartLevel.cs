using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Resets scene when colliding with Death Collider
public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    string ballTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ballTag)
        {
            // Reloads this scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
