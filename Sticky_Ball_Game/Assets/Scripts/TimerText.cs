using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    private float time = 5;

    public PlayerController PlayerController;
    public GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        gameoverText.SetActive(false);
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
        PlayerController.isPlaying = false;
        yield return new WaitForSeconds(2.0f);

    }
}
