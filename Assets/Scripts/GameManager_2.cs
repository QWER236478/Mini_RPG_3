using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameManager_2 : MonoBehaviour
{

    // 적 정보 

    public Animator enemyAnimator;
    public Transform enemyTransform;
    public int enemyHP;
    public int enemyAtk;

    // 적 UI 

    public TMP_Text txtEnemyHPValue;
    public Slider sliderEnemy_HP;

    // 플레이어 정보

    public int playerHP;
    public int playerMP;
    public int playerAtk1;
    public int playerAtkCost1;
    public int playerAtk2;
    public int playerAtkCost2;

    // 플레이어 UI

    public TMP_Text txtPlayerHPValue;
    public Slider sliderPlayer_HP;
    
    public TMP_Text txtPlayerMPValue;
    public Slider sliderPlayer_MP;

    public GameObject Clear_POPUP;

    // 이펙트

    public GameObject HitEF1;
    public GameObject HitEF2;

    // 사운드

    public AudioSource Sword_Slash;
    public AudioSource Double_Slash;
    public AudioSource Slime_Die;

    public bool canAttack = true;

    void Start()
    {
        sliderPlayer_HP.maxValue = playerHP;
        sliderPlayer_HP.value = playerHP;

        sliderPlayer_MP.maxValue = playerMP;
        sliderPlayer_MP.value = playerMP;

        sliderEnemy_HP.maxValue = enemyHP;
        sliderEnemy_HP.value = enemyHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack1()
    {
        enemyAnimator.SetTrigger("Hit");
        if (canAttack == false)
            return;

        if (playerMP < playerAtkCost1)
            return;

        enemyHP -= playerAtk1;
        if (enemyHP <= 0)
        {
            enemyHP = 0;
            enemyAnimator.SetTrigger("Die");
            Slime_Die.Play();
            canAttack = false;
            Clear_POPUP.SetActive(true);
            
            CancelInvoke();
        }

        Instantiate(HitEF1);

        Sword_Slash.Play();

        ChangeEnemyInfo();

        canAttack = false;

        Invoke("DelayReset", 4);
        Invoke("MonsterAttack", 2);
    }

    public void Attack2()
    {
        enemyAnimator.SetTrigger("Hit2");
        if (canAttack == false)
            return;

        if (playerMP < playerAtkCost2)
            return;

        playerMP -= playerAtkCost2;

        enemyHP -= playerAtk2;
        if (enemyHP <= 0)
        { 
            enemyHP = 0;
            enemyAnimator.SetTrigger("Die");
            Slime_Die.Play();
            canAttack = false;
            Clear_POPUP.SetActive(true);

            CancelInvoke();
        }

        ChangeEnemyInfo(); 
        ChangePlayerInfo();

        Instantiate(HitEF2);

        Double_Slash.Play();

        canAttack = false;

        Invoke("DelayReset", 4);
        Invoke("MonsterAttack", 2);
    }   
    
    // 몬스터의 공격
    public void MonsterAttack()
    {
        enemyAnimator.SetTrigger("Attack");
        playerHP -= enemyAtk;
        if (playerHP <= 0) 
        {
            playerHP = 0;
        }
        ChangePlayerInfo();
    }


    // 몬스터의 체력 변화
    public void ChangeEnemyInfo()
    {
        txtEnemyHPValue.text = enemyHP.ToString();
        sliderEnemy_HP.value = enemyHP;
    }    

    // 플레이어의 체력 변화
    public void ChangePlayerInfo()
    {
        txtPlayerHPValue.text = playerHP.ToString();
        sliderPlayer_HP.value = playerHP;

        txtPlayerMPValue.text = playerMP.ToString();
        sliderPlayer_MP.value = playerMP;
    }

    // 딜레이
    void DelayReset()
    {
        canAttack = true;
    }

    public void GoToEnding()
    {
        SceneManager.LoadScene("Ending");
    }

}
