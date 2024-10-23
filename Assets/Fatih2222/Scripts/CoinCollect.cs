using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public static CoinCollect instance;
    [SerializeField] private GameObject coinforbag_prefab;
    [SerializeField] private Transform spawn_point;
    public int coin_count = 0;

    public List<GameObject> coins = new List<GameObject>();


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }




    void ThrowBag()
    {
        GameObject new_coin = Instantiate(coinforbag_prefab, spawn_point.position, Quaternion.identity);
        coins.Add(new_coin);
        coin_count += 1;
    }

    public void RemoveToCoinFromList(GameObject trash)
    {
        if (trash != null)
        {
            coins.Remove(trash);
            Destroy(trash);
            coin_count -= 1;
        }
        else
        {
            Destroy(coins[coins.Count - 1]);
            coins.RemoveAt(coins.Count - 1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            ThrowBag();
        }
    }
}
