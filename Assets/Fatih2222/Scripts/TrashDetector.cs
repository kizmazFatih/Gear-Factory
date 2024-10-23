using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDetector : MonoBehaviour
{
    [SerializeField] private CoinCollect coinCollect_cs;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "3Dcoin")
        {
            coinCollect_cs.RemoveToCoinFromList(other.gameObject);
        }
    }
}
