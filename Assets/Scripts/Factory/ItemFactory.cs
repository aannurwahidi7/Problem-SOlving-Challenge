using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] itemPrefab;
    public GameObject ball;

    private float x;
    private float y;
    private Vector3 position;
    private Vector3 ballPosition;

    public GameObject FactoryMethod(int tag)
    {
        RandomPosition(x, y);
        ballPosition = ball.transform.position;
        GameObject item = Instantiate(itemPrefab[tag]);

        if((item.transform.position - ballPosition).magnitude < 2.1)
        {
            RandomPosition(x, y);
            item.transform.position = position;
        }

        else
        {
            item.transform.position = position;
        }
        
        return item;
    }

    private void RandomPosition(float x, float y)
    {
        x = Random.Range(-5.8f, 6.3f);
        y = Random.Range(-3f, 3.6f);
        position = new Vector2(x, y);
    }
}
