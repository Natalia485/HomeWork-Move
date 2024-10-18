using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloverRun : MonoBehaviour
{
    [SerializeField] private Transform _player; 
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = (_player.position - transform.position).normalized;
        transform.Translate(direction * _speed);
    }
}
