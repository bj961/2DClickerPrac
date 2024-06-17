using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserInfo
{
    public static UserInfo myInfo { get => GameManager.Instance.userInfo; }

    public delegate void SetGold(int value);
    private event SetGold setGold;
    public delegate void SetIncome(int value);
    private event SetIncome setIncome;
    public delegate void SetMiner(int value);
    private event SetMiner setMiner;

    // TODO :
    // ���� BigInterger�� ����
    // �ʼ� �������׸� �����ϴ°� �����̹Ƿ� �ڷ��� int�� �����Ͽ���.
    private int gold = 0;
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            setGold?.Invoke(gold);
        }
    }

    private int income = 1;
    public int Income
    {
        get
        {
            return income;
        }
        set
        {
            income = value;
            setIncome?.Invoke(income);
        }
    }

    private int miner = 1;
    public int Miner
    {
        get
        {
            return miner;
        }
        set
        {
            miner = value;
            setMiner?.Invoke(miner);
        }
    }

    public void SetGoldEvent(SetGold action)
    {
        setGold += action;
        setGold.Invoke(gold);
    }

    public void RemoveGoldEvent(SetGold action)
    {
        setGold -= action;
    }

    public void SetIncomeEvent(SetIncome action)
    {
        setIncome += action;
        setIncome.Invoke(income);
    }

    public void RemoveIncomeEvent(SetIncome action)
    {
        setIncome -= action;
    }

    public void SetMinerEvent(SetMiner action)
    {
        setMiner += action;
        setMiner.Invoke(miner);
    }

    public void RemoveMinerEvent(SetMiner action)
    {
        setMiner -= action;
    }
}
