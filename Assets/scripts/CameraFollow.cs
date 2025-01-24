using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject. FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player)
            return;
        // Get x from player
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if(tempPos.x < minX){
            tempPos.x = minX;
        }
        if(tempPos.x > maxX){
            tempPos.x = maxX;
        }
        transform.position = tempPos;
    }
}
