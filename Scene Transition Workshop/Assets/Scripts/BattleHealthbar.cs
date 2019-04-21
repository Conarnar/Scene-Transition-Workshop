using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHealthbar : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Image image;

    public int health = 100;

    Color[] colors = new Color[] { Color.red, Color.green, Color.blue };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Health: {health}/100";
        image.fillAmount = health / 100f;
    }

    public void Damage(int i)
    {
        health -= i;
    }
}
