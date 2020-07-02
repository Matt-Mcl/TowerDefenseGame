using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1Script : MonoBehaviour
{
    private int frames = 0;

    public GameObject projectile;

    GameObject p = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        //print(frames);//
        //print("Found enemy");//
        //Destroy(GameObject.Find("Enemy1"));//
        if (frames % 30 == 0) {
            if (other.GetComponent<Enemy1Script>().health > 0) {
                p = Instantiate(projectile, transform.position, Quaternion.identity, other.gameObject.transform);
                //print("Shooting");//
                other.GetComponent<Enemy1Script>().health -= 10;
            } else {
                print("Destroy");
                Destroy(other.gameObject);
            }
        }
        
        if (p) {
            //print(p.transform.position);//
            //print(other.gameObject.transform.position);//
            //print("Navigating");//
            float step =  400.0f * Time.deltaTime; 
            p.transform.position = Vector3.MoveTowards(p.transform.position, other.gameObject.transform.position, step);
        }

        frames++;
    }
    
    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.GetComponent<Enemy1Script>().health <= 0) {
            Destroy(other.gameObject);
        }

        Destroy(p);
    }

}
