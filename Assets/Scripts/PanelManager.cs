using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject StopPanel;     // Спрайт StopPanel
    public GameObject GoToSchool;      // Спрайт GoToSchool

    private int clickCount = 0;        // счетчик успешных кликов

    // Метод вызывается при клике на любой из трёх спрайтов
    public void RegisterClick()
    {
        clickCount++;
        if (clickCount >= 3)
        {
            // После третьего клика активируем GoToSchool и деактивируем StopPanel
            if (StopPanel != null)
                StopPanel.SetActive(false);
            if (GoToSchool != null)
                GoToSchool.SetActive(true);
        }
    }
}