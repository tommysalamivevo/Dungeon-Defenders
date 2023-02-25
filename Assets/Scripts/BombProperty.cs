using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombProperty : MonoBehaviour
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 objectPosition = transform.position;
        Instantiate(myGameObject, new Vector3(objectPosition.x, objectPosition.y, objectPosition.z), Quaternion.identity );
        Destroy(this.gameObject);
    }
}
