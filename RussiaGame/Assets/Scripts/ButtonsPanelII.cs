using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPanelII : MonoBehaviour
{
    [SerializeField] Buttons buttons;

    public void BandeiraRussia()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[2].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[2].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void BandeiraURSS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[3].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[3].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulinariaBebidas()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[5].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[5].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulinariaComidas()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[6].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[6].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulinariaVodka()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[7].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[7].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }

    public void CulturaMatrioskas()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[8].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[8].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulturaMusicaDanca()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[9].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[9].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulturaVestimenta()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[10].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[10].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulturaVodka()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[7].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[7].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CulturaXadrez()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[11].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[11].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesUM() //vodka eu acho
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[7].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[7].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesDOIS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[12].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[12].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesTRES()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[13].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[13].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesQUATRO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[14].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[14].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesCINCO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[15].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[15].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesSEIS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[16].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[16].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesSETE()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[17].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[17].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void CuriosidadesPUTIN()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[48].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[48].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void EconomiaMoeda()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[18].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[18].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void EconomiaRussia()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[19].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[19].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void EsportesCOPA()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[21].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[21].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void EsportesINVERNO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[22].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[22].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void GuerraRevRussa()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[25].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[25].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void GuerraPrimeira()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[26].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[26].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void GuerraSegunda()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[27].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[27].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void GuerraFria()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[28].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[28].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void GuerraUcrania()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[29].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[29].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();

    }
    public void PontosTuristicosUM()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[33].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[33].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosDOIS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[34].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[34].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosTRES()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[35].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[35].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosQUATRO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[36].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[36].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosCINCO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[37].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[37].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosSEIS()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[38].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[38].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosSETE()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[39].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[39].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosOITO()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[40].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[40].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosNOVE()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[41].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[41].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosDEZ()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[42].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[42].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void PontosTuristicosONZE()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[43].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[43].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void SobreNossoTrabalhoComoCriamos()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[46].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[46].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
    public void SobreNossoTrabalhoCreditos()
    {
        buttons.GetComponent<AudioSource>().Play();
        buttons.panelNumber = 3;
        buttons.tertiaryPanelsIII[47].SetActive(true);
        LeanTween.moveX(buttons.tertiaryPanelsIII[47].GetComponent<RectTransform>(), 0, 1f).setEaseOutBack();
    }
}