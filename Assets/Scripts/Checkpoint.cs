using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Checkpoint currentCheckpoint;

    [SerializeField]
    private float activatedScale = 1.5f, deactivatedScale = 1;

    [SerializeField]
    private Color activatedColor, deactivatedColor;

    private SpriteRenderer spriteRenderer;


    // Use this for initialization
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        DeactivateCheckpoint();
    }

    private void DeactivateCheckpoint()
    {
        transform.localScale = Vector3.one * deactivatedScale;
        spriteRenderer.color = deactivatedColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bool playerTouchedNewCheckpoint = currentCheckpoint != this;

            if (playerTouchedNewCheckpoint)
            {
                if (currentCheckpoint != null)
                {
                    currentCheckpoint.DeactivateCheckpoint();
                }
                ActivateCheckpoint();
            }
        }
    }

    private void ActivateCheckpoint()
    {
        currentCheckpoint = this;
        transform.localScale = Vector3.one * activatedScale;
        spriteRenderer.color = activatedColor;
    }


}
