using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void StartScene(int sceneNumber)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNumber);
    }
}
