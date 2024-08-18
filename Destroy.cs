using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Output of the word "destroy" to the console
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Output of the word "destroy" to the console
        Destroy(this.gameObject);
    }
}
