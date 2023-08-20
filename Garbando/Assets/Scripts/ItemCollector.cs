using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int rubbish = 0;

    [SerializeField] private TextMeshProUGUI rubbishText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rubbish"))
        {
            Destroy(collision.gameObject);
            rubbish++;
            rubbishText.text = "Rubbish: " + rubbish;
        }
    }
}
