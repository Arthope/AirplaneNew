using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;

    private int _lengthLevel = 100;
    private int _minimalWidthLevel = -15;
    private int _maximalWidthLevel = 15;
    private int _depthLevel = 6;

    public void Start()
    {
        for (int i = 0; i < _lengthLevel; i++)
        {
            if(Random.Range(0,3) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(_minimalWidthLevel, _maximalWidthLevel), _depthLevel);
                Instantiate(_coinPrefab, position, Quaternion.identity);
            }
        }
    }
}
