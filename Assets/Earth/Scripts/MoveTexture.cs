using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public Material material;
    public Vector2 newOffset = new Vector2(0.5f, 0); // Define o novo deslocamento

    void Start()
    {
        if (material != null)
        {
            material.mainTextureOffset = newOffset;
        }
    }
}
