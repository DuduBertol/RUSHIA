using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStartScreen : MonoBehaviour
{
    [SerializeField] RectTransform slideStartText;
    [SerializeField] Buttons buttons;
    
    private void Start() 
    {
           LeanTween.moveX(this.gameObject.GetComponent<RectTransform>(), 0, 3f).setEaseOutBack();
           LeanTween.moveY(slideStartText, -130, 1f).setLoopPingPong();
    }
    void Update()
    {
    }

    public void SlideUp()
    {
        buttons.GetComponent<AudioSource>().Play();
        LeanTween.moveX(this.gameObject.GetComponent<RectTransform>(), -1400, 3f).setEaseInOutBack();
        Destroy(slideStartText.gameObject);
        LeanTween.moveX(buttons.generalPanelI.GetComponent<RectTransform>(), 0, 3f).setDelay(1f).setEaseOutBack();
    }
}
