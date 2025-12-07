using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public PanelManager panelManager;

    private void OnMouseDown()
    {
        if (panelManager != null)
        {
            panelManager.RegisterClick();
        }
    }
}
