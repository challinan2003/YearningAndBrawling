using UnityEngine;

public class TestOfTest : MonoBehaviour
{
    public GameObject Zombie;
    void Update()
    {
        if (Input.GetKey("space"))
        {
            Debug.Log("Running destroy");
            Object.Destroy(Zombie, 0);
        }
    }
}
