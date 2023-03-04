using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManagerStart : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] Image imageRenderer;
    [SerializeField] Image imageRight;
    [SerializeField] Image imageLeft;
    [SerializeField] Color alphaColor;
    
    [SerializeField] Color normalColor;
    [SerializeField] List<Sprite> levelPreview = new List<Sprite>();
    [SerializeField] TMP_Text levelText;

    [SerializeField] GameObject levelSelectPanel;

    private void Update() 
    {
        ShowSprites();
        ShowExtraSprites();
    }

    private void ShowSprites()
    {
        for(int i = 0; i <= levelPreview.Count; i++)
        {
            if(level == i)
            {
                
                imageRenderer.sprite = levelPreview[i];
                levelText.text = "LEVEL "+ (i + 1).ToString();
            }
        }
    }

    private void ShowExtraSprites()
    {
        if(imageRenderer.sprite == levelPreview[0]) //LEVEL 1
        {
            imageLeft.color = alphaColor; //LEVEL 5
            imageRight.sprite = levelPreview[1]; //LEVEL 2
        }
        if(imageRenderer.sprite == levelPreview[1]) //LEVEL 2
        {
            imageLeft.color = normalColor;
            imageLeft.sprite = levelPreview[0]; //LEVEL 1
            imageRight.sprite = levelPreview[2]; //LEVEL 3
        }
        if(imageRenderer.sprite == levelPreview[2]) //LEVEL 3
        {
            imageLeft.sprite = levelPreview[1]; //LEVEL 2
            imageRight.sprite = levelPreview[3]; //LEVEL 4
        }
        if(imageRenderer.sprite == levelPreview[3]) //LEVEL 4
        {
            imageRight.color = normalColor;
            imageLeft.sprite = levelPreview[2]; //LEVEL 3
            imageRight.sprite = levelPreview[4]; //LEVEL 5
        }
        if(imageRenderer.sprite == levelPreview[4]) //LEVEL 5
        {
            imageLeft.sprite = levelPreview[3]; //LEVEL 4
            imageRight.color = alphaColor; //LEVEL 1
            
        }
    }

#region Buttons OnClick Functions
    public void PlayGame()
    {
        levelSelectPanel.SetActive(true);
    }
    public void LevelSelector()
    {
        if(level == 0)
        {
            SceneManager.LoadScene("LevelOne");
        }
        else if (level == 1)
        {
            SceneManager.LoadScene("LevelTwo");
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("LevelThree");
        }
        else if (level == 3)
        {
            SceneManager.LoadScene("LevelFour");
        }
        else if (level == 4)
        {
            SceneManager.LoadScene("LevelFive");
        }

    }

    public void RightButton()
    {
        level++;
        if(level == 5)
        {
            level = 4;
        }
    }
    public void LeftButton()
    {
        level--;
        if(level == -1)
        {
            level = 0;
        }
    }

#endregion
}
