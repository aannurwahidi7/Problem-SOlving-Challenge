using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody2D rigidbody2D;

    public float xForce;
    public float yForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        BallControl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BallControl()
    {
        float randomDirection = Random.Range(1, 5);

        // Untuk memberikan gaya pada bola secara acak;
        switch (randomDirection)
        {
            case 1:
                // Memberi gaya pada pojok kanan atas
                rigidbody2D.AddForce(new Vector2(xForce, yForce));
                break;
            case 2:
                // Memberi gaya pada pojok kanan bawah
                rigidbody2D.AddForce(new Vector2(xForce, -yForce));
                break;
            case 3:
                // Memberi gaya pada pojok kiri atas
                rigidbody2D.AddForce(new Vector2(-xForce, yForce));
                break;
            case 4:
                // Memberi gaya pada pojok kiri bawah
                rigidbody2D.AddForce(new Vector2(-xForce, -yForce));
                break;
        }
       
    }
}
