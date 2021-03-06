﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    #region Data
    [SerializeField] private const ulong _priceCoef = 2;
    [SerializeField] private const ulong _startPrice = 10;
    [SerializeField] private UpgradeDialog _dialogUI;
    #endregion

    #region Interface
    public static ulong PriceOfLevel(int level)
    {
        return _startPrice * (ulong)Mathf.Pow(_priceCoef, level) ; 
    }
    #endregion

    #region Methods
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _dialogUI.ShowDialog(other.gameObject.GetComponent<Player>());
        } 
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.CompareTag("Player"))
        {
            _dialogUI.HideDialog();
        }
    }
    #endregion

}
