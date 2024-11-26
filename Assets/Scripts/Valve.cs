using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public static bool ValveIsOpen = false;
    public GameObject valve;
    private Animator anim;

    void Start()
    {
        anim = valve.GetComponent<Animator>();
    }
    public void Open()
    {
        if (ValveIsOpen == false)
        {
            anim.Play("ValveOpen");
            ValveIsOpen = true;
        }
    }
    public void Close()
    {
        if (ValveIsOpen)
        {
            anim.Play("ValveClose");
            ValveIsOpen = false;
        }
    }
}
