using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;
    public int intialDelay = 60;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        HealthMeter healthmeter = FindObjectOfType<HealthMeter>();
        int healthlog = healthmeter.remainingHearts;
        if(healthmeter.remainingHearts == 0)
        {
            Instantiate(loseScreen, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }

    IEnumerator SpawnEnemy()
    {
        HealthMeter healthmeter = FindObjectOfType<HealthMeter>();
        yield return new WaitForSeconds(intialDelay);
        if(healthmeter.remainingHearts >= -1)
        {
            Instantiate(winScreen, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
