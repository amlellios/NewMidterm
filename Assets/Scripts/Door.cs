using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField]
    string sceneToLoad;

    private void OnTriggerStay2D(Collider2D collision)
    {
        // This code gets called each frame player is inside trigger.
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Action"))
            {
                SceneManager.LoadScene("EndGame");
            }
        }
    }

}
