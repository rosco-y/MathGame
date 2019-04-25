using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cNewItemTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        cItemPool.Instance.Get().gameObject.SetActive(true);
    }
}
