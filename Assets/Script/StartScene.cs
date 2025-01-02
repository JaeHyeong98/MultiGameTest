using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Multiplayer;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public bool isTest;

    public GameObject multiUI;
    public GameObject canvas;

    private GameObject title;
    private GameObject joinLoading;
    private Camera mainCam;

    public void Awake()
    {
        if(!isTest)
        {
            canvas.SetActive(true);
            multiUI.SetActive(false);
            title = canvas.transform.Find("Title").gameObject;
            title.SetActive(true);
            joinLoading = canvas.transform.Find("JoinLoading").gameObject;
            joinLoading.SetActive(false);
            mainCam = Camera.main;
        }
    }

    public void JoinSession()
    {
        joinLoading.SetActive(true);
    }

    public async void JoinedSession()
    {
        await Task.Delay(1000);
        joinLoading.SetActive(false);
        mainCam.gameObject.SetActive(false);
        multiUI.SetActive(false);
    }

}
