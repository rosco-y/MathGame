using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cItemPool : MonoBehaviour
{

    Queue<cItemPricer> _pool = new Queue<cItemPricer>();
    Vector3 _position;
    Quaternion _rotation;
    static cItemPool _instance;

    public static cItemPool Instance
    {
        get { return _instance; }
    }


    public cItemPricer _prefab;

    private void Awake()
    {
        _instance = this;
        _position = new Vector3(-1.061f, 1.275f, 0f);
        _rotation = Quaternion.identity;
        Get().gameObject.SetActive(true);
    }

    public cItemPricer Get()
    {

        if (_pool.Count == 0)
        {
            AddItems(1);
        }

        cItemPricer item =  _pool.Dequeue();
        item.transform.position = _position;
        item.transform.rotation = _rotation;
        return item;
    }


    void AddItems(int count)
    {
        for (int i = 0; i < count; i++)
        {
            cItemPricer item = Instantiate(_prefab);
            _pool.Enqueue(item);
        }
    }

    public void RestoreToPool(cItemPricer item)
    {
        item.gameObject.SetActive(false);        
        _pool.Enqueue(item);
    }
}
