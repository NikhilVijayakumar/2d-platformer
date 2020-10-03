using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleGameObjectButton : MonoBehaviour
{
    public const string k_ButtonNameCancel = "Cancel";
    public GameObject objectToToggle;    
    public bool resetSelectionAfterClick;

    void Update()
    {
        if (objectToToggle.activeSelf && Input.GetButtonDown(k_ButtonNameCancel))
        {
            SetGameObjectActive(false);
        }
    }

    public void SetGameObjectActive(bool active)
    {
        objectToToggle.SetActive(active);
      
        if (resetSelectionAfterClick)
            EventSystem.current.SetSelectedGameObject(null);
    }
}
