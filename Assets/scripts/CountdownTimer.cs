using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public string leveltoload;
    private float timer = 180f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        timerSeconds.text = timer.ToString("f2");

        if (timer <= 0)
        {
            Application.LoadLevel(leveltoload);
        }
    }
}
