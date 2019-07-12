using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outline : MonoBehaviour
{

    public GameObject line;
    public GameObject objeto;
    public GameObject text;
    public GameObject plan;

    bool view;



    // Start is called before the first frame update
    void Start()
    {

        line.SetActive(false);
        objeto.SetActive(false);
        text.SetActive(false);
        plan.SetActive(false);
        view = false;

    }


    private void OnMouseEnter()
    {

        if (view == false && detectAnimation.pode == true)
        {
            line.SetActive(true);
            text.SetActive(true);
        }
    }

    private void OnMouseExit()
    {

            line.SetActive(false);
            text.SetActive(false);     

    }

    private void OnMouseDown()
    {
        objeto.SetActive(true);
        plan.SetActive(true);

        line.SetActive(false);
        text.SetActive(false);

        view = true;
    }


    // Update is called once per frame
    void Update()
    {

        if (CloseView.closeView)
        {
            view = false;
            objeto.SetActive(false);
            plan.SetActive(false);
           CloseView.closeView = false;
        }

    }
}
