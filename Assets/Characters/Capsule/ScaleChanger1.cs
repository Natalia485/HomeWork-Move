using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger1 : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;

    private void Update()
    {
        transform.localScale += new Vector3(_rateOfIncrease, _rateOfIncrease, _rateOfIncrease);
    }
}
