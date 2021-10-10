using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private int size;
    public List<GameObject> spawnPool;

    private float x;
    private float y;
    private int sizeItem = 0;
    private const int MAX_ITEM = 6;

    [SerializeField]
    MonoBehaviour factory;
    IFactory Factory { get { return factory as IFactory; } }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 3);
    }

    private void Spawn()
    {
        int randomItem;
        GameObject item;
        Vector2 position;
        size = Random.Range(0, 7);

        if(sizeItem < 7)
        {
            Factory.FactoryMethod(size);
        }

        else if(sizeItem == 0)
        {
            for (int i = 0; i < size; i++)
            {
                sizeItem += 1;
                randomItem = Random.Range(0, spawnPool.Count);
                item = spawnPool[randomItem];

                x = Random.Range(-5.8f, 6.3f);
                y = Random.Range(-3f, 3.6f);
                position = new Vector2(x, y);

                Instantiate(item, position, item.transform.rotation);
            }
        }
        
        else
        {
            return;
        }
    }
}
