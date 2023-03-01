using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public GameObject bullet;
    public float offset = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("bom");
            Vector3 pos = transform.position;
            pos.x += offset;
            Instantiate(bullet, pos, transform.rotation);
        }
    }
}
