using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        int number = int.Parse(col.gameObject.name);
        mainScript.sortedNumber = number;
    }
}
