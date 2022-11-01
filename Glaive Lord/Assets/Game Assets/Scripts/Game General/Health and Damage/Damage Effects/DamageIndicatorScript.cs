using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageIndicatorScript : MonoBehaviour
{
    //Prefab
    [SerializeField]
    private TextMeshPro prefab;
    //Script Instance
    public static DamageIndicatorScript Instance;

    void Awake()
    {
        Instance = this;
    }

    public void CreateIndicator(Vector3 position, int damageAmount, bool IsCritical)
    {
        TextMeshPro textMesh;
        textMesh = Instantiate(prefab, position, Quaternion.identity);
        
        string text = damageAmount.ToString();
        textMesh.SetText(text);
    }
}
