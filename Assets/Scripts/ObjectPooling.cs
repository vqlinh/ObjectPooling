using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    private List<GameObject> pooledObject=new List<GameObject>();
    private int amountToPool = 20;
    public GameObject bulletPrefabs;

    public static ObjectPooling instance { get; private set; }
    private void Awake()
    {
        if (instance != null & instance != this) Destroy(this);
        else instance = this;
    }
    void Start()
    {
        for (int i=0;i<amountToPool;i++)
        {
            GameObject obj=Instantiate(bulletPrefabs);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
    }
    public GameObject GetPoolOjbect()
    {
        for (int i=0;i<pooledObject.Count;i++)
        {
            if (!pooledObject[i].activeInHierarchy) return pooledObject[i];
        }

        return null;
    }
}
