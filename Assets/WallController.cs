using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    public int copyCount = 2;
    public GameObject bulletOrjin;
    public int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("geldi");

        if (other.gameObject.tag == "Bullet" && counter == 0)
        {
            Vector3 p = other.gameObject.transform.position;
            Debug.Log("değdi");
            for (int i = 0; i < copyCount; i++)
            {
                Debug.Log("oldu");
                // GameObject CoinClone = Instantiate(coinOriginal);
                GameObject CoinClone = Instantiate(bulletOrjin, transform.position , Quaternion.Euler(-transform.rotation.x+30+i, -transform.rotation.y, -transform.rotation.z));
                CoinClone.name = "CoinClone-" + (i + 1);
                //CoinClone.transform.parent = other.gameObject.transform;
                counter++;
            }
        }
    }
}
