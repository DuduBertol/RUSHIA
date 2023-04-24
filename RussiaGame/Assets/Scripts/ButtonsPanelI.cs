using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPanelI : MonoBehaviour
{
    [SerializeField] Buttons buttons;

     /*public void Bandeiras()
    {
        buttons.panelNumber = 2;
        buttons.generalPanelI.SetActive(false);
        buttons.secondaryPanelsII[2].SetActive(true);
        buttons.tertiaryPanelsIII[2].SetActive(false);
    }
    
    public void OpenRussiaBandeira()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[2].SetActive(true);
    }*/

    public void Alfabeto()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[0].SetActive(true);
    }
    public void Atualidades()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[2].SetActive(true);
    }
    public void Bandeiras()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[0].SetActive(true);
    }
    public void Clima()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[4].SetActive(true);
    }
    public void Culinaria()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[1].SetActive(true);
    }
    public void Cultura()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[2].SetActive(true);
    }
    public void Curiosidades()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[3].SetActive(true);
    }
    public void Economia()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[4].SetActive(true);
    }
    public void Educacao()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[20].SetActive(true);
    }
    public void Esportes()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[5].SetActive(true);
    }
    public void Fauna()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[23].SetActive(true);
    }
    public void Flora()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[24].SetActive(true);
    }
    public void Guerras()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[6].SetActive(true);
    }
    public void Localizacao()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[31].SetActive(true);
    }
    public void PoderMilitar()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[32].SetActive(true);
    }
    public void Politica()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[33].SetActive(true);
    }
    public void PontosTuristicos()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[7].SetActive(true);
    }
    public void Populacao()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[33].SetActive(true);
    }
    public void URSS()
    {
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[45].SetActive(true);
    }

    public void SobreNossoTrabalho()
    {
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[8].SetActive(true);
    }
}
