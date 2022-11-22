using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int Damage = 1;
    [SerializeField] private GameObject _effectPrefab;
    [SerializeField] private Rigidbody Rigidbody;
    [SerializeField] private float ConstantForceValue;

    private void FixedUpdate()
    {
        Rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);
    }

    public void Die()
    {
        Instantiate(_effectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}