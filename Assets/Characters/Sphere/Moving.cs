using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection;

    void Update()
    {
        transform.Translate(_moveDirection);
    }
}
