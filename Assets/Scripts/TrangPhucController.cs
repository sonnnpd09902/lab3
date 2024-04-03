using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangPhucController : MonoBehaviour
{
    public GameObject trangPhuc;
    void Start()
    {
        HideMenu();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (trangPhuc.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }

    void ShowMenu()
    {
        trangPhuc.SetActive(true);
        Time.timeScale = 0f;
    }

    void HideMenu()
    {
        trangPhuc.SetActive(false);
        Time.timeScale = 1f;
    }
}
