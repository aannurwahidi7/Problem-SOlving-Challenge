using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody2D rigidbody2D;
    private CircleCollider2D circleCollider;

    private Vector2 movement;
    private Vector3 mousePosition;
    private Vector2 direction;

    public string SCENE_NAME;

    public float xForce;
    public float yForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();

        SCENE_NAME = SceneManager.GetActiveScene().name;        

        if(SCENE_NAME == "Problem 2" || SCENE_NAME == "Problem 3")
        {
            BallControl();
        }
        
        else
        {
            circleCollider.sharedMaterial = null;
        }
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

    private void FixedUpdate()
    {
        //Mendapatkan nilai input horizontal (-1,0,1)
        float h = Input.GetAxisRaw("Horizontal");

        //Mendapatkan nilai input vertical (-1,0,1)
        float v = Input.GetAxisRaw("Vertical");

        switch (SCENE_NAME)
        {
            case "Problem 4":
                Move(h, v);
                break;
            case "Problem 5":
            case "Problem 6":
            case "Problem 7":
            case "Problem 8":
            case "Problem 9":
                if (Input.GetMouseButton(0))
                {
                    MoveWithCursor();
                }                
                break;
        }
    }

    public void Move(float h, float v)
    {
        //Set nilai x dan y
        movement.Set(h, v);

        //Menormalisasi nilai vector agar total panjang dari vector adalah 1
        movement = movement.normalized * speed * Time.deltaTime;

        //Move to position
        rigidbody2D.MovePosition(rigidbody2D.position + movement);
    }

    private void MoveWithCursor()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rigidbody2D.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
