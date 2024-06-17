using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShop : UIBase
{
    [SerializeField] private ItemBase ItemPickaxe;
    [SerializeField] private ItemBase ItemMiner;


    void Start()
    {
        UserInfo.myInfo.SetMinerEvent(ItemMiner.SetText);
    }

    private void OnDestroy()
    {
        UserInfo.myInfo.RemoveMinerEvent(ItemMiner.SetText);
    }
}
