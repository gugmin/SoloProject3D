using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

[System.Serializable]
public class ChangeUIBar
{
    [HideInInspector]
    public float curValue;
    public float StartValue;
    public Image uiBar;

    public float GetPercentage()
    {
        return curValue / StartValue;
    }
}

public class InteractionObject : MonoBehaviour, IInteractable
{
    public ChangeUIBar interactingUI;

    void Start()
    {
        interactingUI.curValue = interactingUI.StartValue;
    }

    void Update()
    {
        interactingUI.uiBar.fillAmount = interactingUI.GetPercentage();
        if (interactingUI.curValue <= 0f)
        {
            Destroy(gameObject);
        }

        if (interactingUI.uiBar.gameObject.activeSelf == false)
        {
            StopCoroutine("Subtruct");
        }
    }

    public void OnInteract()
    {
        //TODO 인벤 만들면 넣어주는 기능 추가
        Destroy(gameObject);
    }

    public void OnInteracting()
    {
        StartCoroutine("Subtruct");
    }

    public void UnInteracting()
    {
        StopCoroutine("Subtruct");
        interactingUI.curValue = interactingUI.StartValue;
    }

    IEnumerator Subtruct()
    {
        while (interactingUI.curValue > 0)
        {
            interactingUI.curValue -= 1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
