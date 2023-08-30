using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PopUp : MonoBehaviour
{
    public GameObject ui;
    void Start()
    {
        
    }
    void Update()
    {
        if (UnityEngine.XR.Interaction.Toolkit.InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(XRNode.RightHand), UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button.PrimaryButton, out bool value, .7f))
        {
            ui.SetActive(true);
        }
        if (UnityEngine.XR.Interaction.Toolkit.InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(XRNode.RightHand), UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button.SecondaryButton, out bool value2, .7f))
        {
            ui.SetActive(false);
        }
    }
}
