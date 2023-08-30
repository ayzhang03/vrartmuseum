using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ColorCanvas : MonoBehaviour
{
    public GameObject colorMenu;
    public GameObject colorBackground;
    public GameObject BBrushR;
    public GameObject BBrushL;
    public GameObject GBrushR;
    public GameObject GBrushL;
    public GameObject RBrushR;
    public GameObject RBrushL;
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
                BBrushR.SetActive(false);
                BBrushL.SetActive(false);
                GBrushR.SetActive(false);
                GBrushL.SetActive(false);
                RBrushR.SetActive(false);
                RBrushL.SetActive(false);
                pauseMenu.SetActive(false);
                pauseBackground.SetActive(false);
            }
        }
    }
}
