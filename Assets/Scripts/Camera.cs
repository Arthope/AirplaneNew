using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;
   
    private void Update()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
    }
}
