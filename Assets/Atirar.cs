using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject bala;
    float delta = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta > 0.25)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                bala.layer = 8;
                Instantiate(bala, this.transform.position, this.transform.rotation);
                delta = 0;
            }

            else if(this.gameObject.tag == "Inimido")
            {
                bala.layer = 9;
                Instantiate(bala, this.transform.position, this.transform.rotation);
                delta = 0;
            }
        }
    }
}

