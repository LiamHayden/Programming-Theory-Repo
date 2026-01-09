using UnityEngine;

public class Cube : Shape
{
    void Start()
    {

        Renderer renderer = GetComponent<Renderer>();

        UniColor = renderer.sharedMaterial;
        Name = this.gameObject.name;

    }
    protected override void OnMouseDown()
    {
        Debug.Log($"Hello, I am a { UniColor.name} {Name}");
    }
}
