using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPanelI : MonoBehaviour
{
    [SerializeField] Buttons buttons;

    public void Alfabeto()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[0].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[0].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Atualidades()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[1].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[1].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Bandeiras()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[0].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[0].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Clima()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[4].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[4].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Culinaria()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[1].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[1].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Cultura()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[2].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[2].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Curiosidades()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[3].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[3].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Economia()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[4].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[4].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Educacao()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[20].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[20].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Esportes()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[5].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[5].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Fauna()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[23].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[23].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Flora()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[24].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[24].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Guerras()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[6].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[6].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Localizacao()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[30].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[30].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PoderMilitar()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[31].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[31].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Politica()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[32].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[32].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicos()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[7].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[7].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void Populacao()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[44].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[44].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void URSS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[45].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[45].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }

    public void SobreNossoTrabalho()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 2;
        buttons.secondaryPanelsII[8].SetActive(true);
        LeanTween.moveX(buttons.secondaryPanelsII[8].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
}
