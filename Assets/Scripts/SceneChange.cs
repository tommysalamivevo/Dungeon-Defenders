using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void MainMenu() {  
        SceneManager.LoadScene("Main Menu");  
    }  
    public void Options() {  
        SceneManager.LoadScene("Options");  
    }  
    public void Scene3() {  
        SceneManager.LoadScene("Scene3");  
    }  
}   