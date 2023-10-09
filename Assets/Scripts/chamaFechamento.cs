using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chamaFechamento : MonoBehaviour
{
    public void FecharGame() {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
