using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UserInfo userInfo;
    bool isAutoClickOn = false;
    public Coroutine autoClickCoroutine;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        userInfo = new UserInfo();

        if(autoClickCoroutine == null)
        {
            autoClickCoroutine = StartCoroutine("AutoClick");
        }
    }

    public void OnClick()
    {
        userInfo.Gold += userInfo.Income * (1 + userInfo.Miner);
        // TODO : ���� ���
    }

    IEnumerator AutoClick()
    {
        while (isAutoClickOn)
        {
            Debug.Log("AutoClick!");
            OnClick();
            yield return new WaitForSeconds(1f);
        }
    }
}
