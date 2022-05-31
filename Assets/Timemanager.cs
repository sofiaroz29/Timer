using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager : MonoBehaviour
{

    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtTimeCustom;
    public float customTime;
    public bool isCounting = false;

    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTime.text = elapsedTime.ToString();
        txtTimeFloored.text = Mathf.Floor(elapsedTime).ToString();

        txtTimeCustom.text += Time.deltaTime.ToString();

        if (isCounting)
        {
            txtTimeCustom.text += Time.deltaTime.ToString();
        }

    }
}
