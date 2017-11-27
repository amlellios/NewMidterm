using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
        [SerializeField]
    string sceneToLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {

    
        // This code gets called each frame player is inside trigger.
        if (collision.gameObject.tag == "Player")
        {

            PlayerRespawn playerRespawn =
            collision.gameObject.GetComponent<PlayerRespawn>();

            playerRespawn.Respawn();
        }
    }

}
