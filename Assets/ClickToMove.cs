using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    Camera mainCamera;
    float moveSpeed = 5f;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetPosition = GetMousePositionInCameraCoordinates();
            MoveTo(targetPosition);
        }
    }

    private Vector3 GetMousePositionInCameraCoordinates()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }

    private void MoveTo(Vector3 targetPosition)
    {
        StartCoroutine(MoveTowardsTarget(targetPosition));
    }

    private System.Collections.IEnumerator MoveTowardsTarget(Vector3 targetPosition)
    {
        while (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
