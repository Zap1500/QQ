using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePosition2d : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }
}
