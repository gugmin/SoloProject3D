using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

public interface IInteractable
{
    //��ȣ�ۿ� �� �� ��Ȳ
    void OnInteract();
    void OnInteracting();
    void UnInteracting();
}

public class Interaction : MonoBehaviour
{
    private IInteractable curInteractable;
    private GameObject curInteractGameobject;

    private void Update()
    {
        //��ü ����
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out RaycastHit hit, 2f);
        if (hit.collider != null && hit.collider.gameObject.layer == LayerMask.NameToLayer("InteractObject"))
        {
            if (hit.collider.gameObject != curInteractGameobject)
            {
                curInteractGameobject = hit.collider.gameObject;
                curInteractable = hit.collider.GetComponent<IInteractable>();
                UIManager.instance.itemPromptText.gameObject.SetActive(true);
            }
        }
        else
        {
            //�ʱ�ȭ �� UI ���ֱ�
            curInteractGameobject = null;
            curInteractable = null;
            UIManager.instance.itemPromptText.gameObject.SetActive(false);
            //UIManager.instance.InteractionUIbar.gameObject.SetActive(false);
        }
    }
    
    //press E key
    public void OnInteractionInput(InputAction.CallbackContext context)
    {
        if (curInteractable != null)
        {
            UIManager.instance.itemPromptText.gameObject.SetActive(false);

            if (context.phase == InputActionPhase.Started)
            {
                if (curInteractGameobject.CompareTag("Maker"))
                {
                    //UIManager.instance.InteractionUIbar.gameObject.SetActive(true);
                    curInteractable.OnInteracting();
                }
                else
                {
                    // ������ �ƴ� �����ϴ� �κ�
                    curInteractable.OnInteract();
                }
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                curInteractable.UnInteracting();
            }
            //�ʱ�ȭ
            curInteractGameobject = null;
            curInteractable = null;
        }
    }

}
