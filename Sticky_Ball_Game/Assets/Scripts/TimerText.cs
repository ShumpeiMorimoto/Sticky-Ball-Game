using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public float time;

    public PlayerController PlayerController;
    public GameObject gameoverText;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        gameoverText.SetActive(false);
        restartButton.SetActive(false);
        GetComponent<Text>().text = ((int)time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            StartCoroutine("GameOver");
        }

        if (time < 0) time = 0;
        GetComponent<Text>().text = ((int)time).ToString();

        }

    IEnumerator GameOver()
    {
        gameoverText.SetActive(true);
        restartButton.SetActive(true);
        PlayerController.isPlaying = false;
        yield return new WaitForSeconds(2.0f);

    }
}
