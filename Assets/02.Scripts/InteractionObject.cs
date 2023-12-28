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
public enum cube { gold = 1, ingredient}

public class InteractionObject : MonoBehaviour, IInteractable
{
    public ChangeUIBar interactingUI;
    public GameObject _gameObject; //prefab
    public Transform spawnPoint;

    void Start()
    {
        interactingUI.curValue = interactingUI.StartValue;
    }

    void Update()
    {
        if (interactingUI.curValue <= 0f)
        {
            if (_gameObject.CompareTag("Item"))
            {
                UIManager.instance.ingredient -= 1;
            }
            else if (_gameObject.CompareTag("leaf"))
            {
                UIManager.instance.gold -= 1000;
            }
            Instantiate(_gameObject, spawnPoint);
            interactingUI.curValue = interactingUI.StartValue;
            UnInteracting();
        }

        if (UIManager.instance.InteractionUIbar.gameObject.activeSelf == false)
        {
            UnInteracting();
        }
    }

    public void OnInteract()
    {
    }

    public void OnInteracting()
    {
        if (UIManager.instance.ingredient == 0 && _gameObject.CompareTag("Item"))
        {
            UIManager.instance.errorPopup.gameObject.SetActive(true);
            Invoke("ClosePanel", 2f);
        }
        else if (UIManager.instance.gold == 0 && _gameObject.CompareTag("leaf"))
        {
            UIManager.instance.errorPopup.gameObject.SetActive(true);
            Invoke("ClosePanel", 2f);
        }
        else
        {
            StartCoroutine("Subtract");
        }
    }

    public void UnInteracting()
    {
        interactingUI.curValue = interactingUI.StartValue;
        interactingUI.uiBar.fillAmount = interactingUI.GetPercentage();
        UIManager.instance.InteractionUIbar.gameObject.SetActive(false);
        StopCoroutine("Subtract");
    }

    IEnumerator Subtract()
    {
        UIManager.instance.InteractionUIbar.gameObject.SetActive(true);
        while (interactingUI.curValue > 0)
        {
            interactingUI.curValue -= 1f;
            interactingUI.uiBar.fillAmount = interactingUI.GetPercentage();
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void ClosePanel()
    {
        UIManager.instance.errorPopup.gameObject.SetActive(false);
    }
}
