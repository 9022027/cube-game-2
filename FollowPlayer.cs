using UnityEngine;
public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset; 
    
    // Update is called once per frame
    void Update () {
        transform.position = player.position + offset; // this code makes the camera follow the cube with the measurements of the offset
    }
}
