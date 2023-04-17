using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject generalPanelI;
    [SerializeField] List<GameObject> secondaryPanelsII = new List<GameObject>();
    [SerializeField] List<GameObject> tertiaryPanelsIII = new List<GameObject>();
    [SerializeField] int panelNumber;
    
    public void OpenBandeiras()
    {
        panelNumber = 2;
        generalPanelI.SetActive(false);
        secondaryPanelsII[2].SetActive(true);
        tertiaryPanelsIII[2].SetActive(false);
    }
    
    public void OpenRussiaBandeira()
    {
        panelNumber = 3;
        tertiaryPanelsIII[2].SetActive(true);
    }

    public void OpenCulinaria()
    {
        panelNumber = 2;
        generalPanelI.SetActive(false);
        secondaryPanelsII[4].SetActive(true);
        tertiaryPanelsIII[4].SetActive(false);
    }

    public void OpenBebidaCulinaria()
    {
        panelNumber = 3;
        tertiaryPanelsIII[4].SetActive(true);
    }

    private void Update() 
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
    }

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
