using UnityEngine;
using UnityEngine.UI;

public class MouseMagnifier : MonoBehaviour
{
    public RectTransform magnifier;      // The circular mask
    public RectTransform zoomedImage;    // The zoomed RawImage inside
    public Canvas canvas;                // Your UI Canvas
    public float zoom = 2f;              // How much to zoom

    void Update()
    {
        Vector2 localPoint;
        Vector2 mousePos = Input.mousePosition;

        // Convert screen point to Canvas local point
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            mousePos,
            canvas.worldCamera,
            out localPoint
        );

        // Move the magnifier to follow mouse
        magnifier.anchoredPosition = localPoint;

        // Move zoomed image in opposite direction * zoom
        zoomedImage.anchoredPosition = -localPoint * zoom;
    }
}
