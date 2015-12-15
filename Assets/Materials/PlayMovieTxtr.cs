using UnityEngine;
using System.Collections;

public class PlayMovieTxtr : MonoBehaviour
{
    public MovieTexture movTexture;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.mainTexture = movTexture;
            movTexture.Play();
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.mainTexture = movTexture;
            movTexture.Stop();
        }

    }
}
