using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection;

    private void Update()
    {
        transform.Translate(_moveDirection * Time.deltatime);
    }
}
