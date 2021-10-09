using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private int size;
    public List<GameObject> spawnPool;

    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        int randomItem;
        GameObject item;
        Vector2 position;
        size = Random.Range(1, 7);

        for(int i = 0; i < size; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            item = spawnPool[randomItem];

            x = Random.Range(-7.5f, 6.5f);
            y = Random.Range(-3f, 3.6f);
            position = new Vector2(x, y);

            Instantiate(item, position, item.transform.rotation);
        }               
    }
}
