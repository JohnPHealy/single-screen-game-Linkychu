using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class COOLUI : MonoBehaviour
{
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 startPos;
    private int score;
    public GameObject none;
    public GameObject jump;
    public GameObject shield;
    public GameObject speed;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateUI();
        none.SetActive(true);
        jump.SetActive(false);
        shield.SetActive(false);
        speed.SetActive(false);
    }

    // Update is called once per frame
    public void Addscore(int scoreAmt)
    {
        score += scoreAmt;
    }

    private void UpdateUI()
    {
        addScore.Invoke(score.ToString());
    }

}
