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
            transform.rotation *= Quaternion.Euler(0, 1, 0); 
        }
    }
}
