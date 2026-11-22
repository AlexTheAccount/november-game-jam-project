using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string GameSceneName = "Main";
    [SerializeField] GameObject MainContainer;
    [SerializeField] GameObject CreditsContainer;

    public void OpenScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }

    public void OpenMain()
    {
        MainContainer.SetActive(true);
        CreditsContainer.SetActive(false);
    }

    public void OpenCredits()
    {
        MainContainer.SetActive(false);
        CreditsContainer.SetActive(true);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
