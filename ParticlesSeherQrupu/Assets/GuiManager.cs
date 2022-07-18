using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiManager : MonoBehaviour
{
    [SerializeField] private GUIStyle myGuiStyle;

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100,100,700,700));

        GUILayout.Button("new Button",myGuiStyle);

        GUILayout.EndArea();
    }


}
