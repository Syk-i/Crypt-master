using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPickup : MonoBehaviour {
    public int CoinsToAdd;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<CoinManager>().StashCoins(CoinsToAdd);
            CoinsToAdd += 1;
            Destroy(gameObject);

        }

    }
}
