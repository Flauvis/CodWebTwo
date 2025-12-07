using UnityEngine;
using UnityEngine.UI; // для работы с UI элементами

public class ShowPanelOnClick : MonoBehaviour
{
    public GameObject panel; // ссылка на панель, которая будет отображаться
    private float displayTime = 1f; // время отображения панели
    private float timer = 0f;
    private bool isPanelActive = false;

    void Start()
    {
        if(panel != null)
            panel.SetActive(false); // скрываем панель по умолчанию
    }

    void OnMouseDown()
    {
        if(panel != null)
        {
            panel.SetActive(true);
            isPanelActive = true;
            timer = displayTime; // запускаем таймер
        }
    }

    void Update()
    {
        if(isPanelActive)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                panel.SetActive(false);
                isPanelActive = false;
            }
        }
    }
}