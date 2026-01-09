using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Name { get; set; }
    public Material UniColor { get; set; }


    protected abstract void OnMouseDown();
}
