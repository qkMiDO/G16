using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraY : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,player.transform.position.y, transform.position.z);
    }
}
