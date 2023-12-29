using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class GetItem : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        if (gameObject.CompareTag("leaf"))
        {
            UIManager.instance.ingredient++;
            Destroy(gameObject);
        }
        else if(gameObject.CompareTag("Item"))
        {
            UIManager.instance.item += 1;
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("SellBox"))
        {
            if (UIManager.instance.item > 0)
            {
                UIManager.instance.item -= 1;
                UIManager.instance.gold += 1200;
            }
        }
    }

    public void OnInteracting()
    {
    }

    public void UnInteracting()
    {
    }
}
