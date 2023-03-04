using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelThree : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject russianWinterPanel;
    [SerializeField] GameObject russianWinter;

    private void Update() 
    {
        if(player.berlinWall)
        {
            russianWinterPanel.SetActive(true);
        }
    }

    public void QuitBerlinWallPanel()
    {
        player.russianWinter = false;
        russianWinterPanel.SetActive(false);
        Destroy(russianWinter, 0.1f);
        //Destruir Muro
        //Animação e Som de Explosão
    }
}
