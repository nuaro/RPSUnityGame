using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {

    public void OnMouseUp()
    {
        Debug.Log("press button name "+name);
    }
}
