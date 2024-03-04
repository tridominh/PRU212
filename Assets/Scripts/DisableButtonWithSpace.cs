using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisableButtonWithSpace : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        // Check if the spacebar is pressed and the button is selected
        if (Input.GetKeyDown(KeyCode.Space) && button.gameObject == EventSystem.current.currentSelectedGameObject)
        {
            // Deselect the button
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}
