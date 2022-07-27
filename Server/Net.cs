using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Net : MonoBehaviour
{
    public Button btn_Login, btn_SelectRole;
    void Start()
    {
        btn_Login.onClick.AddListener(() =>
        {
            NetManager.Instance().ConnectToServer("192.168.43.128", 4399, OnConnect);
        });

        btn_SelectRole.onClick.AddListener(() =>
        {
            NetManager.SendChooseRole(1, null);
        });
    }

    private void OnConnect(bool bSuccess, string result)
    {
        if (bSuccess)
        {
            NetManager.SendUserLogin(NetManager.Instance().Ret_Login, false);
        }
    }

    void Update()
    {
        
    }
}
