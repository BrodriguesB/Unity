using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruir : MonoBehaviour
{
    float delta = 0;
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 5)
        {
            Destroy(this.gameObject);
        }

        
    }
}
