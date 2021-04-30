using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float move_speed = 0f;
    float vertical = 0; 
    private void Awake()
    {  
    }
    enum character_anim
    {
        move,
        run,
        dance,
        die
    }
    public void character_move()
    { 
        move_speed = 20f;

        transform.position += Vector3.right *move_speed*Time.deltaTime;
        transform.gameObject.GetComponent<Animator>().Play(character_anim.move.ToString());
    }
    public void character_run()
    { 
        move_speed = 15f;

        transform.position += Vector3.right * move_speed * Time.deltaTime;
        transform.gameObject.GetComponent<Animator>().Play(character_anim.run.ToString());
    }
    public void Update()
    {
        character_move();
    }
}
