using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{

    public GameObject myGameObject;
    public int cost = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateNewObject()
    {
        Currency currency = FindObjectOfType<Currency>(); // get a reference to the Currency instance in the scene

        if (currency.currency >= cost) {
            Instantiate(myGameObject, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
