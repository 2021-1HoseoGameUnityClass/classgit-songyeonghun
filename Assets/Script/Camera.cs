using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject playerObj = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 vector3 = new Vector3();
        vector3.x = playerObj.transform.position.x;
        vector3.y = playerObj.transform.position.y;
        vector3.z = -10;

        transform.position = vector3;
    }
}
