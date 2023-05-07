using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Companion : MonoBehaviour
{
   public NavMeshAgent robot;
   public Transform Player;

   private void Update()
   {
      robot.SetDestination(Player.position);
   }
}
