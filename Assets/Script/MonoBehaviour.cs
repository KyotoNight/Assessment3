using UnityEngine;
using System.Collections;
public class Music : MonoBehaviour
{
    AudioSource a;
    void Start() { a = GetComponent<AudioSource>(); }
    public void Paly() { }
    void OnGUI()
    {
        if (GUILayout.Button("Button1"))
        {
            a.Play();
        }
    }
}

   