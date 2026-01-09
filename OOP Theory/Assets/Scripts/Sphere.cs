using UnityEngine;

// Inherits from the Shape class
public class Sphere : Shape
{
    void Start()
    {

        Renderer renderer = GetComponent<Renderer>();

        UniColor = renderer.sharedMaterial;
        Name = this.gameObject.name;

    }

    // Overrides the method inherited from Shape
    protected override void HandleClick()
    {
        Debug.Log($"Hello, I am a {UniColor.name} {Name}");
    }

}
