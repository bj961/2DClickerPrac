using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mine : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        MineClicked();
    }

    private void MineClicked()
    {
        Debug.Log("±¤»ê Å¬¸¯");
        UserInfo.myInfo.Gold += UserInfo.myInfo.Income;
    }
}
