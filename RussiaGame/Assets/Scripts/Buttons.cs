using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject levelSelectPanel;

    public void PlayGame()
    {
        levelSelectPanel.SetActive(true);
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
