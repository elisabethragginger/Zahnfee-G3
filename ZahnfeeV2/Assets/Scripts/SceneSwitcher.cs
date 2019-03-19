using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void SceneSwitch()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Angeklickt");
    }

    public void SceneSwitch2()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Angeklickt");
    }
}