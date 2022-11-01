using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PauseMenu : MonoBehaviour
{

    private PlayerInputActions playerControls;
    private InputAction menu;

    [SerializeField]
    private GameObject pauseUI;

    [SerializeField]
    private bool isPaused;
    
    void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        menu = playerControls.MenuActions.Escape;
        menu.Enable();

        menu.performed += Pause;
    }

    private void OnDisable()
    {
        menu = playerControls.MenuActions.Escape;
        menu.Disable();
    }

    void Pause(InputAction.CallbackContext context)
    {
        isPaused = !isPaused;

        if(isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseUI.SetActive(false);
        isPaused = false;
    }

}
