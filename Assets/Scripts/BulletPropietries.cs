using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPropietries : MonoBehaviour
{
    public Vector3 direction = new Vector3(1f, 0f, 0f);
    public float speed = 1f;
    public int damage = 100;
    public float liveTime = 4f;

    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Método para mover el trasform usando la posicion.
    private void Move()
    {
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void DestroyDelay()
    {
        Debug.Log("DESTROY DELAY");
        Destroy(gameObject);
    }
}
