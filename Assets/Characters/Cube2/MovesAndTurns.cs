using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesAndTurns : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private Vector3 _increaseObject;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(0, _rotateSpeed, 0);
        transform.localScale += _increaseObject;
    }
}
