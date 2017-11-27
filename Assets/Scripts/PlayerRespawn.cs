using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
   public void Respawn()
    {
        if (Checkpoint.currentCheckpoint != null)
        {
            // Move player to last checkpoint position.
            // IF there is a current checkpoint!
            gameObject.transform.position = 
                Checkpoint.currentCheckpoint.transform.position;
        }
        else
        {
            // IF there is no current checkpoint, reload the level.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
