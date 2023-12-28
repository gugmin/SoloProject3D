using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        //TODO 인벤 만들면 넣어주는 기능 추가
        Destroy(gameObject);
    }

    public void OnInteracting()
    {
    }

    public void UnInteracting()
    {
    }
}
