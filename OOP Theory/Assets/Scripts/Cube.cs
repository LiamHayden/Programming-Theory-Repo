using UnityEngine;

public class Cube : Shape
{
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        UniColor = renderer.sharedMaterial;
        Name = gameObject.name;
    }

    // Overrides the method inherited from Shape
    protected override void HandleClick()
    {
        Debug.Log($"Hello, I am a {UniColor.name} {Name}");
    }
}
