using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectClic : MonoBehaviour
{

    public static bool clic;

    // Start is called before the first frame update
    void Start()
    {
        clic = false;
    }


    private void OnMouseDown()
    {
        clic = true;
    }

}
