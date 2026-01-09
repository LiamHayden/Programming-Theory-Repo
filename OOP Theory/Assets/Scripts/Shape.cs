using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // Encapsulated properties
    public string Name { get; set; }
    public Material UniColor { get; set; }

    // Abstract method to be implemented by derived classes
    protected abstract void OnMouseDown();
}
