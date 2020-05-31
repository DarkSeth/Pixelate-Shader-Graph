using UnityEngine;

/// <summary>
/// Shader manipulator.
/// Changes pixelate value over time
/// </summary>
public class ShaderManipulator : MonoBehaviour
{
    // Reference to the sprite renderer
    private SpriteRenderer spriteRenderer;

    /// <summary>
    /// Called on first frame
    /// </summary>
    private void Start()
    {
        // Get reference to the sprite renderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Called on every frame
    /// </summary>
    private void Update()
    {
        // Change value in the material
        spriteRenderer.material.SetFloat("Pixelate", (Mathf.Sin(Time.time) + 1) / 2);
    }
}
