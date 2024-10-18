using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private Transform _follover;
    void Update()
    {
        transform.LookAt(_follover);
    }
}
