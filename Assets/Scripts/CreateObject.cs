using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
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

    public void InstantiateNewObject()
    {

        Instantiate(myGameObject, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
