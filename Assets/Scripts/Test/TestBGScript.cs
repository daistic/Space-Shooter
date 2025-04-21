using UnityEngine;

public class TestBGScript : MonoBehaviour
{
    public float speed;

    private Renderer bgRenderer;

    private void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
