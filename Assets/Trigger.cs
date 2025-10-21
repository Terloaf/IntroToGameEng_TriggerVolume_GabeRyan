using UnityEngine;

public class Trigger : MonoBehaviour
{

    public GameObject box;
    public GameObject wall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        box.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        box.SetActive(true);
        wall.SetActive(false);
    }

}
