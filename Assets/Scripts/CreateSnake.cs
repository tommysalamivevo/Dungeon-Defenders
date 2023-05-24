using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSnake : MonoBehaviour
{

    public GameObject myGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        Currency currency = FindObjectOfType<Currency>(); // get a reference to the Currency instance in the scene

        if (currency.currency >= 350) {
            currency.DecreaseCurrencyAnvil(); // access the DecreaseCurrencyBomb method using the reference
            currency.DecreaseCurrencyAnvil();
            currency.DecreaseCurrencyAnvil(); 
            currency.DecreaseCurrencyAnvil();
            currency.DecreaseCurrencyBomb();
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
            Instantiate(myGameObject, new Vector3(mousePosition.x, mousePosition.y, mousePosition.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}

