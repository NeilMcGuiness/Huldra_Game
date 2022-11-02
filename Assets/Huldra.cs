using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huldra : MonoBehaviour
{

    private Animator anim;
    private float blendState;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("GenerateRandomAnimState", 1.0f, 10.0f);

    }

    void GenerateRandomAnimState () 
    {
         float random = Random.Range(0f, 1f);

         if (random < 0.33) {
            blendState = 0.001f;
         } else {
            if (random < 0.66) {
            blendState = 0.5f;
            } else {
            blendState = 1f;
            }
         }
        // Debug.Log("GENERATE RANDOM STATE - random = " + random + " state = " + blendState);

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Blend", blendState, 1.0f, Time.deltaTime);

        // // 
        //  // If the left mouse click occurs
        // if (Input.GetKeyDown(KeyCode.Mouse0)){
        //     // Start a coroutine (similar to threads?)
        //     Debug.Log("LEFT CLICK");
        //     anim.SetFloat("Blend", 0f, 0, Time.deltaTime);
        //     // anim.SetFloat("Blend", 0f);

        // }
        // if (Input.GetKeyDown(KeyCode.Mouse1)){
        //     // Start a coroutine (similar to threads?)
        //     Debug.Log("Right CLICK");
        //     // anim.SetFloat("Blend", 0.5f);
        //     anim.SetFloat("Blend", 0.5f, 0, Time.deltaTime);

        // }
        // if (Input.GetKeyDown(KeyCode.Mouse2)){
        //     // Start a coroutine (similar to threads?)
        //     Debug.Log("Middle CLICK");
        //     // anim.SetFloat("Blend", 1f);
        //     anim.SetFloat("Blend", 1f, 0, Time.deltaTime);
        // }
        
        // // float blendAmount = anim.GetFloat("Blend");
        // Debug.Log("ANIM Blend Amount - " + anim.GetFloat("Blend"));
    }
}
