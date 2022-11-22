using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   [SerializeField] public TextMeshProUGUI Text;
   [SerializeField] private int _coins;
   [SerializeField] private int _coinValue;

    public void AddCoin()
    {
        _coins += _coinValue;
        Text.text = _coins.ToString();
    }
}
