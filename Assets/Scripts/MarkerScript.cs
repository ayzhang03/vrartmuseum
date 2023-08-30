using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    public GameObject RightHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = RightHand.transform.position;
        Debug.Log(RightHand.transform.position);
        Debug.Log(this.gameObject.transform.position);
    }
}
