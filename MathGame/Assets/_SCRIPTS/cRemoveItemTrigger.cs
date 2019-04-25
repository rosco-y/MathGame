using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRemoveItemTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        cItemPricer item = other.GetComponent<cItemPricer>();
        item.gameObject.SetActive(false);
        cItemPool.Instance.RestoreToPool(item);
    }
}
