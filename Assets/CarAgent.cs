using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class CarAgent : Agent
{
    // Start is called before the first frame update
    Rigidbody R;
    void Start()
    {
        R = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        Vector3 f = Vector3.zero;
        f.x = vectorAction[0];
        f.z = vectorAction[1];
        R.AddForce(f);
    }
}