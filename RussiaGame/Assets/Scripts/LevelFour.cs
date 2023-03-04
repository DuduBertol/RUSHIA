using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFour : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject berlinWallPanel;
    [SerializeField] GameObject berlinWall;

    private void Update() 
    {
        if(player.berlinWall)
        {
            berlinWallPanel.SetActive(true);
        }
    }

    public void QuitBerlinWallPanel()
    {
        player.berlinWall = false;
        berlinWallPanel.SetActive(false);
        Destroy(berlinWall, 0.1f);
        //Destruir Muro
        //Animação e Som de Explosão
    }
}
