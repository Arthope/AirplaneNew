using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private AudioSource _shotSound;
    [SerializeField] private float _shotPeriod;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_timer > _shotPeriod)
            {
                _timer = 0;
                CreateBullet();
            }
        }
    }

    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(_bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;
        _shotSound.Play();
    }
}