using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera Speler_wit;
    public Camera Speler_zwart;

    void Start()
    {
        // Zorg ervoor dat één camera actief is bij het starten van het spel
        Speler_wit.enabled = true;
        Speler_zwart.enabled = false;
    }

    void Update()
    {
        // Schakel tussen camera's wanneer de speler bijvoorbeeld op de spatiebalk drukt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Wissel de actieve status van de camera's
        Speler_wit.enabled = !Speler_wit.enabled;
        Speler_zwart.enabled = !Speler_zwart.enabled;
    }
}
