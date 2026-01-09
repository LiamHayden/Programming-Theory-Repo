using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Name { get; set; }
    public Material UniColor { get; set; }

    // Unity message must be concrete
    private void OnMouseDown()
    {
        HandleClick();
    }

    // Your extensibility point
    protected abstract void HandleClick();
}
