using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int PlayerCurrentCoins;

     void Start()
    {
        //PlayerCurrentCoins;
    }

     void Update()
    {

        
    }
    public void StashCoins(int CoinsToAdd)
    {
        PlayerCurrentCoins += CoinsToAdd;
        Debug.Log(CoinsToAdd);
        
    }

    public void ResetCoin()
    {
        PlayerCurrentCoins = 0;
    }






}