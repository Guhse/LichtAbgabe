using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    [SerializeField] public GameObject Lights;
    [SerializeField] public GameObject Player;

    private bool enter = true;

    private void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (enter == true)
        {
            GetComponent<Light>().enabled = true;
           
        }
    }

}
