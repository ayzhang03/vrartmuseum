using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseCanvas : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject background;
    void Update()
    {
        var rightHandDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHandDevices);
        if (rightHandDevices.Count == 1)
        {
            bool isPressed;
            InputDevice device = rightHandDevices[0];
            if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out isPressed) && isPressed)
            {
                pauseMenu.SetActive(true);
                background.SetActive(true);
            }
        }
    }
}
