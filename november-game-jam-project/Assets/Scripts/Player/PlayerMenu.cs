using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;

    public void OnPause(InputValue value)
    {
        PauseMenu.SetActive(!PauseMenu.activeSelf);
    }
}
