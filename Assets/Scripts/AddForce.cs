using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float mass;
    [SerializeField] float acc; //acceleration

    void CalculateForce() 
    {
        mass = GetComponent<Rigidbody>().mass;
        force =  mass * acc;
        GetComponent<Rigidbody>().AddForce(force, force, 0);
        
    }

    public void SetAcc250()
    {
        acc = 250f;
        CalculateForce();
    }

    public void SetAcc300()
    {
        acc = 300f;
        CalculateForce();
    }

    public void SetAcc350()
    {
        acc = 350f;
        CalculateForce();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
