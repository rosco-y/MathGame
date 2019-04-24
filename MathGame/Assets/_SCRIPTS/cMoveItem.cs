using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cMoveItem : MonoBehaviour
{

    public float _speed = 3f;

    Rigidbody _rig;
    private void Awake()
    {
        _rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rig.velocity = new Vector3(_speed, 0f);
    }
}
