using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Companion : MonoBehaviour
{
   public NavMeshAgent robot;
   public Transform Player;
   public Animator anim;

   private void Update()
   {
      robot.SetDestination(Player.position);
   }
}
