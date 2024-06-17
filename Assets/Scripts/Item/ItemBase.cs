using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UserInfo;

public enum eItemType
{
    pickaxe,
    miner
}

public class ItemBase : MonoBehaviour
{
    [SerializeField] private eItemType itemType;
    [SerializeField] private List<Sprite> iconSprites;
    [SerializeField] private Image icon;
    [SerializeField] private TMPro.TMP_Text levelText;
    [SerializeField] private TMPro.TMP_Text costText;
    [SerializeField] protected int increaseValue;

    private Button button;

    private int level = 1;
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
            levelText.text = string.Format("{0:#,##0}", value);
            Cost += cost * level;
        }
    }

    private int cost = 30;
    public int Cost
    {
        get
        {
            return cost;
        }
        set
        {
            cost = value;
            costText.text = string.Format("{0:#,##0}", value);
        }
    }



    private void Start()
    {
        SetUI(itemType);
        button = GetComponent<Button>();
        UserInfo.myInfo.SetGoldEvent(SetButton);

        levelText.text = string.Format("{0:#,##0}", Level);
        costText.text = string.Format("{0:#,##0}", Cost);
    }

    private void OnDestroy()
    {
        UserInfo.myInfo.RemoveGoldEvent(SetButton);
    }

    public void SetButton(int gold)
    {
        if (cost <= gold)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void SetUI(eItemType type)
    {
        this.itemType = type;
        icon.sprite = iconSprites[(int)itemType];
    }

    public void SetText(string str)
    {
        levelText.text = str;
    }

    public void SetText(int value)
    {
        levelText.text = string.Format("{0:#,##0}", value);
    }

    public void SetText(int value, int max)
    {
        levelText.text = string.Format("{0} / {1}", value, max);
    }

    public void ItemClicked() 
    {
        UserInfo.myInfo.Gold -= cost;
        Level++;
    }

}
