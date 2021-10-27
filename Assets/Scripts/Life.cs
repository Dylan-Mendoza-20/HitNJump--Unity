using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int scoreGive = 30;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.obj.addLive();
            Game.obj.addScore(scoreGive);
            AudioManager.obj.playCoin();
            UIManager.obj.updateLives();
            FXManager.obj.showPop(transform.position);
            gameObject.SetActive(false);
        }
    }    
}
