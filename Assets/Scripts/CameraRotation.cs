using UnityEngine;

namespace Assets.Scripts
{
    public class CameraRotation : MonoBehaviour
    {
        // Use this for initialization
        void Start () {
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

            var quaternion = string.Equals(name, "Main Camera") //if object is the main camera (or head)
                ? Quaternion.Euler(-mouseY, 0, 0)                    //rotate only the camera/head on y axis
                : Quaternion.Euler(0, mouseX, 0);                    //otherwise, rotate entire person on x

            transform.rotation *= quaternion;
        }
    }
}
