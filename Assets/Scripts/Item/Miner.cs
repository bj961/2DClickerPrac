using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : ItemBase
{
    public void ItemClicked()
    {
        base.ItemClicked();
        UserInfo.myInfo.Miner += increaseValue;
    }
}
