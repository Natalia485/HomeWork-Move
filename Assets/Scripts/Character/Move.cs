using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private int count = 0;

    private void Update()
    {


        transform.Translate(_movementDirection);



    }
}
