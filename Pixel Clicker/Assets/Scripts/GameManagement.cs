using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public static GameManagement instance;

    // Amounts for text UI
    public Text moneyIndicator;
    public Text level1Indicator;
    public Text level2Indicator;
    public Text level3Indicator;
    public Text level4Indicator;
    public Text level5Indicator;

    public Text level1costIndicator;
    public Text level2costIndicator;
    public Text level3costIndicator;
    public Text level4costIndicator;
    public Text level5costIndicator;

    // Storage for how much of each
    public float moneyCurrent;
    public int level1Current;
    public int level2Current;
    public int level3Current;
    public int level4Current;
    public int level5Current;
    public float level1Cost;
    public float level2Cost;
    public float level3Cost;
    public float level4Cost;
    public float level5Cost;

    // Use this for initialization
    void Start()
    {
        level1Cost = 10;
        level2Cost = 50;
        level3Cost = 10;
        level4Cost = 10;
        level5Cost = 10;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        moneyCurrent += (0.0165f * level1Current)
            + (0.0472f * level2Current);

        moneyIndicator.text = "" + (int)moneyCurrent;
        level1Indicator.text = "" + level1Current;
        level2Indicator.text = "" + level2Current;
        level3Indicator.text = "" + level3Current;
        level4Indicator.text = "" + level4Current;
        level5Indicator.text = "" + level5Current;

        level1costIndicator.text = "" + (int)level1Cost;
        level2costIndicator.text = "" + (int)level2Cost;
        level3costIndicator.text = "" + (int)level3Cost;
        level4costIndicator.text = "" + (int)level4Cost;
    }

    // Function to givemoney on click
    public void GiveMoney()
    {
        moneyCurrent += 1;
    }

    // Function to givepurchase on click
    public void GivePurchaseLevel1()
    {
        if (moneyCurrent >= level1Cost)
        {
            level1Current += 1;
            moneyCurrent -= level1Cost;
            level1Cost = level1Cost * 1.15f;
        }
    }

    public void GivePurchaseLevel2()
    {
        if (moneyCurrent >= level2Cost)
        {
            level2Current += 1;
            moneyCurrent -= level2Cost;
            level2Cost = level2Cost * 1.55f;
        }
    }
}
