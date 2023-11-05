using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text score;
    public int counter = 0;
    public Transform myChildObject;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: 0";
        counter = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yay");
        counter++;
        score.text = "Score: " + counter;
        myChildObject = collision.transform.GetChild(0);
        myChildObject.parent = null;
        myChildObject.transform.localScale = new Vector3(1, 1, 1);
        Destroy(collision.gameObject);

        
        


    }


    

    // Update is called once per frame
    void Update()
    {
        
    }
}
