using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public CanvasGroup UI;
    public CanvasGroup play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))//Changes to play mode
        {
            HideUI();
        }

        if (Input.GetKeyDown(KeyCode.O))//Changes to edit mode
        {
            ShowUI();
        }
    }

    void HideUI()
    {
        UI.alpha = 0.0f;
        play.alpha = 1.0f;
        UI.blocksRaycasts = false;
        play.blocksRaycasts = true;
    }

    void ShowUI()
    {
        UI.alpha = 1.0f;
        play.alpha = 0.0f;
        UI.blocksRaycasts = true;
        play.blocksRaycasts = false;
    }
}
