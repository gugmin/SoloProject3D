using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

public interface IInteractable
{
    //상호작용 할 때 상황
    void OnInteract();
    void OnInteracting();
    void UnInteracting();
}

public class Interaction : MonoBehaviour
{
    public TextMeshProUGUI itemPromptText;
    private IInteractable curInteractable;
    private GameObject curInteractGameobject;
    public Image InteractionUIbar;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out RaycastHit hit, 1f);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject != curInteractGameobject)
            {
                curInteractGameobject = hit.collider.gameObject;
                curInteractable = hit.collider.GetComponent<IInteractable>();
                itemPromptText.gameObject.SetActive(true);
            }

        }
        else
        {
            curInteractGameobject = null;
            curInteractable = null;
            itemPromptText.gameObject.SetActive(false);
            InteractionUIbar.gameObject.SetActive(false);
        }
    }
    
    public void OnInteractionInput(InputAction.CallbackContext context)
    {
        if (curInteractable != null && curInteractGameobject.CompareTag("Item"))
        {
            if (context.phase == InputActionPhase.Started && curInteractable != null)
            {
                curInteractable.OnInteract();
                curInteractGameobject = null;
                curInteractable = null;
                itemPromptText.gameObject.SetActive(false);
            }
        }
        else if (curInteractable != null && curInteractGameobject.CompareTag("Maker"))
        {
            itemPromptText.gameObject.SetActive(false);
            InteractionUIbar.gameObject.SetActive(true);

            if (context.phase == InputActionPhase.Started && curInteractable != null)
            {
                curInteractable.OnInteracting();
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                curInteractable.UnInteracting();
            }
            curInteractGameobject = null;
            curInteractable = null;
        }
    }
}
