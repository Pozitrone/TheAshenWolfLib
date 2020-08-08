﻿using UnityEditor;
using UnityEngine;

namespace TheAshenWolf.Lib.Editor
{
    public class TAWDocumentation : EditorWindow
    {
        private void OnGUI()
        {
            GUIStyle labelStyle = GUI.skin.GetStyle("Label");
            
            labelStyle.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label("Coming soon", labelStyle);

        }
    }
}