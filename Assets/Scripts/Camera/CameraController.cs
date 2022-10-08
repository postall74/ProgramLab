using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [Header("Settings sensivity rotation and position camera"), Space]
    [SerializeField, Range(0.1f,10f)] private float _sensivityCursor = 3f;
    [SerializeField, Range(0.01f, 1f)] private float _sensivityZoom = 0.25f;
    [SerializeField, Range(0f, 360f)] private float _limitRaotionY = 90f;

    private readonly float _zoomMax = 10f;
    private readonly float _zoomMin = 3f;

    private Vector3 _offsetPosition;
    private float _xPostion;
    private float _yPosition;

    private void Start()
    {
        _offsetPosition = new Vector3(_offsetPosition.x, _offsetPosition.y, -_zoomMax);
        transform.position = _target.position + _offsetPosition;
    }

    private void Update()
    {
        Zoom();

        _xPostion = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _sensivityCursor;
        _yPosition += Input.GetAxis("Mouse Y") * _sensivityCursor;
        _yPosition = Mathf.Clamp(_yPosition, -_limitRaotionY, _limitRaotionY);
        if (Input.GetMouseButton(0))
        {
            transform.localEulerAngles = new Vector3(-_yPosition, _xPostion, 0);
            transform.position = transform.localRotation * _offsetPosition + _target.position;
        }
    }

    private void Zoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            _offsetPosition.z += _sensivityZoom;

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            _offsetPosition.z -= _sensivityZoom;

        _offsetPosition.z = Mathf.Clamp(_offsetPosition.z, -_zoomMax, -_zoomMin);
    }
}
