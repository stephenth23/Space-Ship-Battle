using UnityEngine;
using System.Collections;

public class BackgroundScrolling : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public float scrollingSpeed = 0.01f;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 offset = new Vector2(scrollingSpeed * Time.deltaTime, 0);

        meshRenderer.material.mainTextureOffset += offset;
    }
}