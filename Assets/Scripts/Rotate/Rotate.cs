using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform _rotationCenter;
    [SerializeField] private Vector3 _offSet;

    private void Start()
    {
        _offSet = transform.position - _rotationCenter.position;  
    }

    private void Update()
    {
        transform.position = _rotationCenter.position + _offSet;
        transform.RotateAround(_rotationCenter.position, Vector3.up, 20f * Time.deltaTime);
        transform.Rotate(0, 30 * Time.deltaTime, 0);
        _offSet = transform.position -_rotationCenter.position;
    }
}
