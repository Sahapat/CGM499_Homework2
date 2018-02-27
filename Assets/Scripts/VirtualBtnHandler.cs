using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualBtnHandler : MonoBehaviour, IVirtualButtonEventHandler
{
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
                Main.instance.SleepBtnStatus = true;
                break;
            case "Wakeup":
                Main.instance.WakeBtnStatus = true;
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "Sleep":
                Main.instance.SleepBtnStatus = true;
                break;
            case "Wakeup":
                Main.instance.WakeBtnStatus = true;
                break;
        }
    }
}
