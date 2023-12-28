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
            //TODO �κ� ����� �־��ִ� ��� �߰�
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
