using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoreScale : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;

    void Update()
    {
        transform.localScale += new Vector3(_rateOfIncrease, _rateOfIncrease, _rateOfIncrease);
    }
}
