using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SceneCamera : MonoBehaviour
{
    [SerializeField]
    private Camera camera;

    [SerializeField]
    private float scrollSpeed;

    private void Awake()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        Vector3 cameraPosition = camera.transform.position;
        cameraPosition.y += (scrollSpeed) * Input.mouseScrollDelta.y;
        camera.transform.position = cameraPosition;
    }

}
