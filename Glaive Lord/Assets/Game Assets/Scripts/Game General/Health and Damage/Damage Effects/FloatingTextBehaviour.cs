using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatingTextBehaviour : MonoBehaviour
{
    void Awake()
    {
        TextMeshPro textMesh = GetComponent<TextMeshPro>();

        StartCoroutine(Fade(textMesh));
    }

    IEnumerator Fade(TextMeshPro textMesh)
    {
        while (textMesh.alpha > 0)
        {
            textMesh.alpha -= Time.deltaTime;

            transform.Translate(0f, 2f * Time.deltaTime, 0f);

            yield return null;
        }

        Destroy(gameObject);
    }
}
