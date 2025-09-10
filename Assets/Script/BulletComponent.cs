using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        //Destroy Object after few seconds
        Destroy(gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
