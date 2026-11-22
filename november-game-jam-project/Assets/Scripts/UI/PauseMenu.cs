using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] string GameSceneName = "Main";
    [SerializeField] GameObject PauseContainer;

    public void OpenScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }

    public void TogglePause()
    {
        PauseContainer.SetActive(!PauseContainer.activeSelf);
    }
}
