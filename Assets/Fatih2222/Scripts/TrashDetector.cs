using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDetector : MonoBehaviour
{




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "3Dcoin")
        {
            CoinCollect.instance.RemoveToCoinFromList(other.gameObject);
        }
    }
}
