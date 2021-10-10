using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public int damage;
    public AudioSource shootSFX;
    private float timer = 7f;

    float destroyTimer;

    // Start is called before the first frame update
    void Start()
    {
        shootSFX.Play();
        rb.velocity = -transform.right * speed;    
    }

    private void Update()
    {
        destroyTimer += Time.deltaTime;
        if (destroyTimer >= timer)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Hit();
        }
    }

    private void Hit()
    {
        Lives.lives -= damage;
        Destroy(gameObject);
    }
}
