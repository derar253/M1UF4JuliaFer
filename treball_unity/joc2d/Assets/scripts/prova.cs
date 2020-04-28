using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{

    Animator anim;




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.W)) {
            anim.SetInteger("status",1);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("status", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("status",2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetInteger("status", 0);
        }
    }
}
