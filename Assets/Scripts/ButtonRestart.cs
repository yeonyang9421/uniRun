using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonRestart : MonoBehaviour
{

    public void Restart(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
