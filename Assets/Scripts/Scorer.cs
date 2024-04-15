using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "HitObject") {
            score++;
            Debug.Log("你已经撞了" + score + "次了");
        }
    }
}
