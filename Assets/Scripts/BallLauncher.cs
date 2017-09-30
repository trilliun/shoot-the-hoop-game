using UnityEngine;

namespace Assets.Scripts
{
    public class BallLauncher : MonoBehaviour
    {
        public GameObject BallPrefab;
        public float BallSpeed = 5.0f;

        // Use this for initialization
        void Start () {
		    
        }
	
        // Update is called once per frame
        void Update ()
        {
            if (Input.GetButtonDown("Fire1")) LaunchNewBall();
        }

        private void LaunchNewBall()
        {
            var ball = CreateBall();
            ball.velocity = Vector3.forward * BallSpeed;
        }

        private Rigidbody CreateBall()
        {
            var instance = Instantiate(BallPrefab);

            //sets position of ball to the camera position
            instance.transform.position = transform.GetComponentInChildren<Camera>().transform.position;

            return instance.GetComponent<Rigidbody>();
        }
    }
}
