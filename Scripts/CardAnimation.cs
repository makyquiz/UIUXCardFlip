using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardAnimation : MonoBehaviour
{
    bool clicked = false;

    void Start()
    { 
        DOTween.SetTweensCapacity(2000, 100);
    }

    void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;

            CameraShake.Shake(0.5f, 0.5f);
            Invoke("CardClickDelay", 0.5f);
        }
    }

    private void OnMouseOver()
    {
        transform.DOScale(2.5f, 0.50f);
    }

    private void OnMouseExit()
    {
        transform.DOScale(2f, 0.50f); 
    }

    void CardClickDelay()
    {
        transform.DOScale(2.5f, 0.50f);
        transform.DOShakeRotation(0.5f, 20f, 25, 10f);
        transform.DORotate(Vector3.up * 180, 1f);
    }
}
