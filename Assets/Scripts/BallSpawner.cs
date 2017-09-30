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
        void Update () {
            if (Input.GetKeyDown(KeyCode.Space))
                Instantiate(BallPrefab);
        }
    }
}
