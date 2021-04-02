using UnityEngine;

public class ItemDraggingComponent : MonoBehaviour
{
    private Vector3 mOffset;

    private float mYCoord;
    void OnMouseDown()
    {
        mYCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).y;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mousePoint.y / 50;
        mousePoint = Camera.main.ScreenToWorldPoint(mousePoint);
        mousePoint.y = mYCoord;
        return mousePoint;
    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
}
