using UnityEngine;

namespace Assets.Scripts
{
    public class BallSpawner : MonoBehaviour
    {
        public GameObject BallPrefab;

        // Use this for initialization
        void Start () {
		    
        }
	
        // Update is called once per frame
        void Update ()
        {
            const float velocityMultiplier = 5.0f;

            if (Input.GetKeyDown(KeyCode.Space)) InstantiateBall(Vector3.down * velocityMultiplier); 
            if (Input.GetKeyDown(KeyCode.UpArrow)) InstantiateBall(Vector3.forward * velocityMultiplier);
            if (Input.GetKeyDown(KeyCode.LeftArrow)) InstantiateBall(Vector3.left * velocityMultiplier);
            if (Input.GetKeyDown(KeyCode.RightArrow)) InstantiateBall(Vector3.right * velocityMultiplier);
            if (Input.GetKeyDown(KeyCode.DownArrow)) InstantiateBall(Vector3.back * velocityMultiplier);
        }

        private void InstantiateBall(Vector3 velocity)
        {
            var instance = Instantiate(BallPrefab);
            var rigidBody = instance.GetComponent<Rigidbody>();
            rigidBody.velocity = velocity;
        }
    }
}
