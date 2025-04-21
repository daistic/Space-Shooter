using UnityEngine;

public class Backgorund : MonoBehaviour
{
    [SerializeField] float speed;

    private Renderer rendererBG;

    private void Start()
    {
        rendererBG = GetComponent<Renderer>();
    }

    private void Update()
    {
        rendererBG.material.mainTextureOffset += Vector2.down * speed * Time.deltaTime;
    }
}
