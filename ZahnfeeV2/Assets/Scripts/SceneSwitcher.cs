using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SceneSwitch ()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneSwitch2 ()
    {
        SceneManager.LoadScene(2);
    }
}

//enum Scenes { Start, Main, End };
//public void LoadStartScene ()
//{
//    SceneManager.LoadScene((int)Scenes.Start);
//}
//public void LoadMainScene()
//{
//    SceneManager.LoadScene((int)Scenes.Main)
//}