using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int lives;
    public GameObject gameOverPanel;
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        lives = 100;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Lives: " + lives;

        if(lives <= 0)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
