using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActivateCutScene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private PlayableDirector playableDirector;


        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playableDirector.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
