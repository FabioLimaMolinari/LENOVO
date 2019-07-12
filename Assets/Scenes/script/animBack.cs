using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animBack : MonoBehaviour
{

    public static bool clicBack;

    // Start is called before the first frame update
    void Start()
    {

        clicBack = false;

    }

    private void OnMouseDown()
    {
        clicBack = true;
    }

}
