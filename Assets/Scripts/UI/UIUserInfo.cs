using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUserInfo : MonoBehaviour
{
    [SerializeField] private Currency currencyGold;
    [SerializeField] private Currency currencyIncome;
    [SerializeField] private Currency currencyMiner;

    void Start()
    {
        UserInfo.myInfo.SetGoldEvent(currencyGold.SetText);
        UserInfo.myInfo.SetIncomeEvent(currencyIncome.SetText);
        UserInfo.myInfo.SetMinerEvent(currencyMiner.SetText);
    }

    private void OnDestroy()
    {
        UserInfo.myInfo.RemoveGoldEvent(currencyGold.SetText);
        UserInfo.myInfo.RemoveIncomeEvent(currencyIncome.SetText);
        UserInfo.myInfo.RemoveMinerEvent(currencyMiner.SetText);
    }
}
