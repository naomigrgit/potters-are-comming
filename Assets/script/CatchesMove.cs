using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class CatchesMove : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public float speed;
    public NavMeshAgent nav;
    public Vector3 Target;


    private void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer>=newtarget)
        {
            newTarget();
            timer = 0;

        }
    }
    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos=myX+Random.Range(myX-500,myX + 500);
        float zPos = myZ + Random.Range(myZ - 500, myZ + 500);

        Target = new Vector3(xPos,gameObject.transform.position.y,zPos);

        nav.SetDestination(Target);
    }
}
