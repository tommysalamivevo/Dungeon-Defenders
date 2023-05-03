using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    // Public variables
    public Text currencyText;

    // Private variables
    public int currency = 100;

    void Start()
    {
        UpdateCurrencyText();
    }

    void UpdateCurrencyText()
    {
        currencyText.text = ": $" + currency.ToString();
    }

    public void IncreaseCurrency()
    {
        currency += 80;
        UpdateCurrencyText();
    }

        public void DecreaseCurrencyPipe()
    {
        currency -= 25;
        UpdateCurrencyText();
    }

        public void DecreaseCurrencyBomb()
    {
        currency -= 50;
        UpdateCurrencyText();
    }

    public void DecreaseCurrencyAnvil()
    {
        currency -= 75;
        UpdateCurrencyText();
    }
}