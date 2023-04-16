using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSummary : MonoBehaviour
{
    [SerializeField] float initialPos;
    [SerializeField] float finalPos;
    void Update()
    {
        if(Input.touchCount > 0 )
        {
            Touch t = Input.GetTouch(0);

            if(t.phase == TouchPhase.Moved)
            {
                if(t.deltaPosition.y > 25 && transform.position.y >= finalPos)
                {
                    LeanTween.moveY(this.gameObject.GetComponent<RectTransform>(), initialPos, 0.5f);
                }
                else if(t.deltaPosition.y < 25 && transform.position.y <= initialPos)
                {
                    LeanTween.moveY(this.gameObject.GetComponent<RectTransform>(), finalPos, 0.5f);
                }
            }
        }
    }

}
