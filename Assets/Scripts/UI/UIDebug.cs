using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDebug : UIBase
{
    public void OnClickIncomePlus()
    {
        UserInfo.myInfo.Income += 100;
    }

    public void OnClickIncomeMinus()
    {
        UserInfo.myInfo.Income -= 100;
    }
    public void OnClickMinerPlus()
    {
        UserInfo.myInfo.Miner += 1;
    }

    public void OnClickMinerMinus()
    {
        UserInfo.myInfo.Miner -= 1;
    }
}
