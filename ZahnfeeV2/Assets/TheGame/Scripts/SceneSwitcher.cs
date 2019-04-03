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

    public void SceneSwitch3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
