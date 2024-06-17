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
        GameManager.Instance.OnClick();
        // TODO :
        // 사운드 출력
        // 마우스 위치에 이펙트(파티클) 생성
    }
}
