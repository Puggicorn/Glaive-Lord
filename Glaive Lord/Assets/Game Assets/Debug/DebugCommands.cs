using UnityEngine;
using UnityEngine.InputSystem;

public class DebugCommands : MonoBehaviour
{
    [SerializeField]
    private PlayerInputActions playerControls;
    private InputAction switchObj;
    private InputAction spawnObj;
    private InputAction testFunc;

    private void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        switchObj = playerControls.DebugActions.Switch;
        switchObj.Enable();
        switchObj.performed += SwitchSpawnable;

        spawnObj = playerControls.DebugActions.Spawn;
        spawnObj.Enable();
        spawnObj.performed += SpawnObject;

        testFunc = playerControls.DebugActions.Test;
        testFunc.Enable();
        testFunc.performed += TestFunction;
    }

    private void OnDisable()
    {
        switchObj.Disable();
        spawnObj.Disable();
        testFunc.Disable();
    }

    [SerializeField] 
    Camera cam;
    [SerializeField]
    DamageIndicatorScript damageIndicator;
    [SerializeField] 
    GameObject target;
    [SerializeField] 
    GameObject Enemy1;

    int i;
    int i2;

    private void SwitchSpawnable(InputAction.CallbackContext context)
    {

        i++;
        if(i < 2 == false)
        {
            i = 0;
        }

    }
    

    private void SpawnObject(InputAction.CallbackContext context)
    {
        GameObject[] spawnables = {target, Enemy1};

        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Instantiate(spawnables[i], new Vector3(mouseWorldPos.x, mouseWorldPos.y , 0), Quaternion.identity);
    }

    private void TestFunction(InputAction.CallbackContext context)
    {
        
    }

}
