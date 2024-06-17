using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxe : ItemBase
{
    public void ItemClicked()
    {
        base.ItemClicked();
        UserInfo.myInfo.Income += Level * increaseValue;
    }
}
