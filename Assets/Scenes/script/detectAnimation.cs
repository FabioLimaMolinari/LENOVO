using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectAnimation : MonoBehaviour
{
    public Animator anim1;

    public static bool pode;

    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();

        pode = true;
    }

    // Update is called once per frame

    void Update()
    {


        if (detectClic.clic)
        {
            anim1.SetBool("goAnim", true);
            anim1.SetBool("backAnim", false);
            pode = false;
            detectClic.clic = false;
           // anim1.Play("GoAnim");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim1.SetBool("goAnim", false);
            anim1.SetBool("backAnim", true);
            pode = true;
        } 
     
    }

    public void AcabouAnimacao()
    {
        //Debug.Log("Callback Animation");
    }
}
