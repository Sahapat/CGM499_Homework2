using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualBtnHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    [SerializeField]
    private Animator HumanAnim;

    private VirtualButtonBehaviour[] vButton;

    private void Start()
    {
        vButton = GetComponentsInChildren<VirtualButtonBehaviour>();
        foreach(VirtualButtonBehaviour vb in vButton)
        {
            vb.RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName)
        {
            case "Sleep":
                if(!Main.instance.SleepBtnStatus)
                {
                    HumanAnim.SetTrigger("Sleep");
                    Main.instance.SleepBtnStatus = true;
                }
                break;
            case "Wake":
                if(!Main.instance.WakeBtnStatus)
                {
                    HumanAnim.SetTrigger("Wake");
                    Main.instance.WakeBtnStatus = true;
                }
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "Sleep":
                Main.instance.SleepBtnStatus = false;
                break;
            case "Wake":
                Main.instance.WakeBtnStatus = false;
                break;
        }
    }
}
