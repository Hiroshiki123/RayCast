using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
 
    void Start()
    {

        Debug.Log("Inicio!");

    }

    void Update()
    {


        if (UnityEngine.Input.GetKey(KeyCode.Space))
        {
           
            ray = new Ray(transform.position, transform.forward);

            Debug.Log("Origem: " + ray.origin);
            RaycastHit hitData;
            Debug.Log("Direção: " + ray.direction);

            if (Physics.Raycast(ray, out hitData))
            {

                

                Vector3 hitPosition = hitData.point;
                Debug.Log(" hitPosition:" +hitPosition);

                
                float hitDistance = hitData.distance;
                Debug.Log("Distancia: " + hitDistance);
                string tag = hitData.collider.tag;
                Debug.Log("Tag:" + tag);
                GameObject hitObject = hitData.transform.gameObject;
                Debug.DrawRay(ray.origin, hitPosition * hitDistance, Color.green);
                StartCoroutine(SphereIndicator(hitPosition));


            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 1000, Color.magenta);
                Debug.Log("Target missed");
            }




        }
    }
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        yield return new WaitForSeconds(0);
        Destroy(sphere);
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        
        Gizmos.DrawRay(ray);
    }
}
