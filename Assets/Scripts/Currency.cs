using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    // Public variables
    public Text currencyText;

    // Private variables
    private int currency = 100;

    void Start()
    {
        UpdateCurrencyText();
    }

    void UpdateCurrencyText()
    {
        currencyText.text = "Currency: " + currency.ToString();
    }

    public void IncreaseCurrency()
    {
        currency += 100;
        UpdateCurrencyText();
    }
}