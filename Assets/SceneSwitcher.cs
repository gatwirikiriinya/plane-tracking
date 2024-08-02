using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToScene2()
    {
        Debug.Log("I am getting clicked");
        SceneManager.LoadScene("FaceFilterScene");
    }
    public void SwitchToScene1()
    {
        Debug.Log("I am getting clicked");
        SceneManager.LoadScene("EntryScene");
    }
}
