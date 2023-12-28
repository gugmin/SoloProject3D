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
    public GameObject cigar;

    void Start()
    {
        interactingUI.curValue = interactingUI.StartValue;
    }

    void Update()
    {
        interactingUI.uiBar.fillAmount = interactingUI.GetPercentage();
        if (interactingUI.curValue <= 0f)
        {
            UIManager.instance.ingredient -= 1;
            Instantiate(cigar);
            interactingUI.curValue = interactingUI.StartValue;
        }

        if (UIManager.instance.InteractionUIbar.gameObject.activeSelf == false)
        {
            StopCoroutine("Subtract");
        }
    }

    public void OnInteract()
    {
    }

    public void OnInteracting()
    {
        if (UIManager.instance.ingredient == 0)
        {
            //°æ°íÃ¢
        }
        else
        StartCoroutine("Subtract");
    }

    public void UnInteracting()
    {
        StopCoroutine("Subtract");
        interactingUI.curValue = interactingUI.StartValue;
    }

    IEnumerator Subtract()
    {
        while (interactingUI.curValue > 0)
        {
            interactingUI.curValue -= 1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
