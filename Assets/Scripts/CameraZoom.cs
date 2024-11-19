using UnityEngine;

public class CameraSizeAdjuster : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField]
    private float targetObjectSize = 5f;
    [Tooltip("Adjust for desired object size")]
    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        float aspectRatio = (float)Screen.width / Screen.height;
        float halfHeight = targetObjectSize / 2f;

        if (aspectRatio >= 1) // (16:9) for an example
        {
            mainCamera.orthographicSize = halfHeight / aspectRatio;
        }
        else // (9:16) for an example
        {
            mainCamera.orthographicSize = halfHeight;
        }
    }
}