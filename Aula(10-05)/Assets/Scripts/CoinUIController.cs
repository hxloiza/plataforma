using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinsChanged += UpdateCoinText;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinsChanged -= UpdateCoinText;
    }

    private void UpdateCoinText(int newCoinsValue)
    {
        coinText.text = newCoinsValue.ToString();
    }
}
