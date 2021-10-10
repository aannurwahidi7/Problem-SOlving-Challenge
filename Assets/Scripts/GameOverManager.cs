using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    bool isDead = false;
    public float restartDelay = 5f;

    float restartTimer;

    // Update is called once per frame
    void Update()
    {
        restartTimer += Time.deltaTime;
        if (restartTimer >= restartDelay)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
