using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int scoreValue;
    public AudioSource itemSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            itemSFX.Play();
            Pickup();
        }
    }

    private void Pickup()
    {        
        ScoreManager.score += scoreValue;
        Destroy(gameObject);
        ItemController.sizeItem -= 1;
    }
}
