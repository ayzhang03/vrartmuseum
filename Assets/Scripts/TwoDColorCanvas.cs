using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TwoDColorCanvas : MonoBehaviour
{
    public GameObject colorMenu;
    public GameObject colorBackground;
    public GameObject Blue;
    public GameObject Purple;
    public GameObject Red;
    public GameObject pauseMenu;
    public GameObject pauseBackground;
    void Update()
    {
        var rightHandDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHandDevices);
        if (rightHandDevices.Count == 1)
        {
            bool isPressed;
            InputDevice device = rightHandDevices[0];
            if (device.TryGetFeatureValue(CommonUsages.primaryButton, out isPressed) && isPressed)
            {
                colorMenu.SetActive(true);
                colorBackground.SetActive(true);
                Blue.SetActive(false);
                Purple.SetActive(false);
                Red.SetActive(false);
                pauseMenu.SetActive(false);
                pauseBackground.SetActive(false);
            }
        }
    }
}
