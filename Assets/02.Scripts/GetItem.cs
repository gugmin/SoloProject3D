using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        if (gameObject.CompareTag("leaf"))
        {
            UIManager.instance.ingredient++;
            Destroy(gameObject);
        }
        else
        {
            //TODO 인벤 만들면 넣어주는 기능 추가
            Destroy(gameObject);
        }
    }

    public void OnInteracting()
    {
    }

    public void UnInteracting()
    {
    }
}
