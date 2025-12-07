using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class ClickableSprite : MonoBehaviour
{
    public string nodeName;
    public string sceneName;
    public float delaySeconds = 5f;
    public bool IEnumerable;
    public bool Used;

    void OnMouseDown()
    {
        if(Used == false)
        {
            Used = true;
            FindAnyObjectByType<DialogueRunner>().StartDialogue(nodeName);
        }
        
        /*Debug.Log("Клик по спрайту!");
        if (IEnumerable == false)
            StartCoroutine(EnableAfterRidding());
            IEnumerable = true; 
        // Твои действия здесь
        */
    }
/*
    private IEnumerator EnableAfterRidding()
    {
        yield return new WaitForSeconds(delaySeconds);
        SceneManager.LoadScene(sceneName);
    }
    */
}
