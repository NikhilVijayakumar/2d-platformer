using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public Selectable defaultSelection;
    public const string k_AxisNameVertical = "Vertical";
    public const string k_AxisNameHorizontal = "Horizontal";
    public const string k_ButtonNameSubmit = "Submit";

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);
    }

    void LateUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (Input.GetButtonDown(k_ButtonNameSubmit)
                || Input.GetAxisRaw(k_AxisNameHorizontal) != 0
                || Input.GetAxisRaw(k_AxisNameVertical) != 0)
            {
                EventSystem.current.SetSelectedGameObject(defaultSelection.gameObject);
            }
        }
    }
}
