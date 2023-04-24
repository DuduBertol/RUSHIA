using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject generalPanelI;
    public List<GameObject> secondaryPanelsII = new List<GameObject>();
    public List<GameObject> tertiaryPanelsIII = new List<GameObject>();
    public int panelNumber;

    /*private void Update() 
    {
        if(panelNumber == 2 && Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < secondaryPanelsII.Count; i++)
            {
                if(secondaryPanelsII[i])
                {
                    secondaryPanelsII[i].SetActive(false);
                    generalPanelI.SetActive(true);
                    panelNumber = 1;
                }
            }
        }
        
        if(panelNumber == 3 && Input.GetKeyDown(KeyCode.Escape))
        { 
            for (int i = 0; i < tertiaryPanelsIII.Count; i++)
            {
                if(tertiaryPanelsIII[i])
                {
                    tertiaryPanelsIII[i].SetActive(false);
                    panelNumber = 2;
                }
            }
        }
    }*/

    public void Return()
    {
        if(panelNumber == 2)
        {
            for (int i = 0; i < secondaryPanelsII.Count; i++)
            {
                if(secondaryPanelsII[i])
                {
                    secondaryPanelsII[i].SetActive(false);
                    generalPanelI.SetActive(true);
                    panelNumber = 1;
                }
            }
        }
        
        if(panelNumber == 3)
        { 
            for (int i = 0; i < tertiaryPanelsIII.Count; i++)
            {
                if(tertiaryPanelsIII[i])
                {
                    tertiaryPanelsIII[i].SetActive(false);
                    panelNumber = 2;
                }
            }
        }
    }
}
