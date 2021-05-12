using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] GameObject GameoverPanel;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(this);
    }

    private void Start()
    {
        GameoverPanel.SetActive(false);
    }
    public void OnClickRestartSceneButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ActivateMenuPanel()
    {
        GameoverPanel.SetActive(true);
    }

    //public void DisActivateMenuPanel()
    //{
    //    menuPanel.SetActive(false);
    //}

    public void OnClickQuitButton()
    {
        Application.Quit();
    }

}
