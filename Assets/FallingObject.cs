using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingObject : MonoBehaviour
{

    // Start is called before the first frame update
    public Rigidbody instCrystalRigidbody;
    
    void Start()
    {
        InvokeRepeating("DropProjectile", 1.0f, 1.0f);
        
    }

    void DropProjectile()
    {
        float rangeZ = Random.Range(-0f, 13f);
        float rangeX = Random.Range(-10, 10);

        GameObject instCrystal = Instantiate(GameObject.Find("SphereGemLarge"));
        
        instCrystal.transform.position = new Vector3(rangeX, 7, rangeZ);
        instCrystalRigidbody = instCrystal.AddComponent<Rigidbody>();

        instCrystalRigidbody.useGravity = true;
        instCrystalRigidbody.isKinematic = false; 
       
        instCrystalRigidbody.drag = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
