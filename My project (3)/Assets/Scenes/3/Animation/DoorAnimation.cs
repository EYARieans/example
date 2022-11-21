using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator doorTop = null;
    [SerializeField] private Animator doorBot = null;
    //[SerializeField] private Animator mydoor1 = null;
    [SerializeField] private bool openTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("hii");
            if(openTrigger)
            {
                doorTop.Play("TopDoor", 0, 0.0f);
                doorBot.Play("DownDoor", 0, 0.0f);

            }
        }
    }
}
