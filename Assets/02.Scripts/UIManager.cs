using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Image InteractionUIbar;
    public TextMeshProUGUI itemPromptText;
    public TextMeshProUGUI ingredientTxt;
    public int ingredient;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        ingredientTxt.text = ingredient.ToString();
    }
}
