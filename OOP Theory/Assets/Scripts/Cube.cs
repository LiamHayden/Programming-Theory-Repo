using UnityEngine;

// Inherits from the Shape class
public class Cube : Shape
{
    void Start()
    {

        Renderer renderer = GetComponent<Renderer>();

        UniColor = renderer.sharedMaterial;
        Name = this.gameObject.name;

    }

    // Overrides the method inherited from Shape
    protected override void OnMouseDown()
    {
        Debug.Log($"Hello, I am a { UniColor.name} {Name}");
    }
}
