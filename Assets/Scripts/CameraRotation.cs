using UnityEngine;

namespace Assets.Scripts
{
    public class CameraRotation : MonoBehaviour
    {
        private Camera _camera;     

        // Use this for initialization
        void Start () {
            _camera = GetComponentInChildren<Camera>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            RotateCamera();
        }

        private void RotateCamera()
        {
            const float rotationSpeed = 5.0f;
            var mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            var mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.localRotation *= Quaternion.Euler(0, mouseX, 0);
            _camera.transform.localRotation *= Quaternion.Euler(-mouseY, 0, 0);
        }
    }
}
