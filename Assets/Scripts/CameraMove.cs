using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
   
    public  void Update()
    {
        if (_target)
        {
             transform.position = _target.position;
        }
    }
}
