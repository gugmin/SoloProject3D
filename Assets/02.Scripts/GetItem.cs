using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        //TODO �κ� ����� �־��ִ� ��� �߰�
        Destroy(gameObject);
    }

    public void OnInteracting()
    {
    }

    public void UnInteracting()
    {
    }
}
