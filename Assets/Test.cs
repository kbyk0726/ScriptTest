using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization	
    public class Boss {
        private int hp = 100;
        private int power = 25;

        public void Attack() {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Defence(int damage) {
            Debug.Log( damage + "のダメージを受けた");
            this.hp -= damage;
        }




        //発展課題----------------------------------
        private int mp = 53;
        public void Magic() {
            if (mp >= 5) {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            } else {
                Debug.Log("MPが足りないため魔法が使えない");
            }
        }
        //------------------------------------------------
    }
    
    
    
    void Start() {




        //課題------------------------------------------

        int[] array = { 1, 2, 3, 4, 5 };

        for(int i = 0;i < array.Length;i++) {
            Debug.Log(array[i]);
        }

        for (int i = array.Length -1;0 <= i;i--) {
            Debug.Log(array[i]);
        }
        //-------------------------------------------------





        //発展課題-----------------------------------------
        Boss boss = new Boss();
        for(int i = 0;i <= 10;i++) {
            boss.Magic();
        }
        //--------------------------------------------------
    }








    // Update is called once per frame
    void Update() {

    }
}