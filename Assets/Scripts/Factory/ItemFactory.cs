using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] itemPrefab;

    public GameObject FactoryMethod(int tag)
    {
        GameObject item = Instantiate(itemPrefab[tag]);
        return item;
    }
}
