using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public float timer, refresh, avgFrameRate;
    public string display = "{0} FPS";
    public Text m_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float timeLapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timeLapse;

        if (timer <= 0) avgFrameRate = (int)(1f / timeLapse);
        m_Text.text = string.Format(display, avgFrameRate.ToString());
    }
}