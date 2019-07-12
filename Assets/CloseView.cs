using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseView : MonoBehaviour
{

    public static bool closeView;


    //public bool test;

    // Start is called before the first frame update
    void Start()
    {

        closeView = false;

    }


    private void OnMouseDown()
    {
        closeView = true;
        Debug.Log("Entrou");
    }

    // Update is called once per frame
}
