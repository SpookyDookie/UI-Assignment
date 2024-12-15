using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_Script : MonoBehaviour
{
    public void GoToSceneOne()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToSceneTwo()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToSceneThree()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToSceneFour()
    {
        SceneManager.LoadScene(3);
    }
}
