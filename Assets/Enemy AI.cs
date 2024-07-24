using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monsterAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator anim;
    public Transform player;
   
    Vector3 dest;

    void Update()
    {
       
        dest = player.position;
        ai.destination = dest;
        if (PickMaterials.matsCollected == 1)
        {
            ai.speed = 1.5f;
            anim.speed = 0.2f;
        }
        if (PickMaterials.matsCollected == 2)
        {
            ai.speed = 1.7f;
            anim.speed = 0.4f;
        }
        if (PickMaterials.matsCollected == 3)
        {
            ai.speed = 1.9f;
            anim.speed = 0.6f;
        }

    }
}
