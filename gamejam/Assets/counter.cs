using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{

    public static int t = 4;//開拓期間
    public static float g;//技術ポイント
    public static float g2;//技術ポイント献上値
    public static int sy;//食物
    public static int h;//人
    private float n ;
    public Slider bar;


    // Use this for initialization
    void Start()
    {
        g = 300.0f;
        bar.maxValue = g;
        sy = 0;
        h = 100;
    }

    // Update is called once per frame
    static void Kikan()
    {
        
        for (t = 4; t == 0; t--)
        {
            float n = Random.value;
            g2 = 1;
            if (g2 >= 1 && g2<=300)
            {
                if(n>=0.1 && n<=0.3)
                {
                    sy += 100;
                }
                else if(n >= 0.4 && n <= 0.6)
                {
                    sy += 250;
                }
                else if(n >= 0.7 && n <= 0.9)
                {
                    sy += 500;
                }
                else
                {
                    sy += 600;
                }
            }
            else if (g2 >= 301 && g2 <= 600)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy += 300;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy += 500;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy += 700;
                }
                else
                {
                    sy += 1000;
                }
            }
            else if (g2 >= 601 && g2 <= 900)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy += 500;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy += 750;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy += 1000;
                }
                else
                {
                    sy += 1500;
                }
            }
            else if (g2 >= 901)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy += 900;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy += 1200;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy += 1500;
                }
                else
                {
                    sy += 2000;
                }
            }
            else
            {
                sy -= 500;
            }

            //人の増殖
            if (sy >= 1 && sy <= 500)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy -= 200;
                    h += 100;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy -= 300;
                    h += 200;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy -= 400;
                    h += 300;
                }
                else
                {
                    sy -= 500;
                    h += 400;
                }
            }
            else if (sy >= 501 && sy <= 1000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy -= 400;
                    h += 300;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy -= 500;
                    h += 400;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy -= 600;
                    h += 500;
                }
                else
                {
                    sy -= 700;
                    h += 600;
                }
            }
            else if (sy >= 1001 && sy <= 2000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy -= 600;
                    h += 550;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy -= 700;
                    h += 650;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy -= 800;
                    h += 750;
                }
                else
                {
                    sy -= 900;
                    h += 900;
                }
            }
            else if (sy >= 2001 && sy <= 5000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy -= 800;
                    h += 700;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy -= 900;
                    h += 800;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy -= 1000;
                    h += 900;
                }
                else
                {
                    sy -= 1500;
                    h += 1200;
                }
            }
            else
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    sy -= 1000;
                    h += 900;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    sy -= 1500;
                    h += 1100;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    sy -= 2000;
                    h += 1500;
                }
                else
                {
                    sy -= 2500;
                    h += 2000;
                }
            }
            //技術ポイント加算
            if (h>= 1 && h <= 1000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    g += 200;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    g += 400;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    g += 600;
                }
                else
                {
                    g += 800;
                }
            }
            else if (h >= 1001 && h <= 1500)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    g += 500;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    g += 700;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    g += 900;
                }
                else
                {
                    g += 1000;
                }
            }
            else if (h >= 1501 && h <= 2000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    g += 500;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    g += 700;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    g += 900;
                }
                else
                {
                    g += 1000;
                }
            }
            else if (h >= 2001 && h <= 3000)
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    g += 900;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    g += 1000;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    g += 1500;
                }
                else
                {
                    g += 2000;
                }
            }
            else
            {
                if (n >= 0.1 && n <= 0.3)
                {
                    g += 1500;
                }
                else if (n >= 0.4 && n <= 0.6)
                {
                    g += 2000;
                }
                else if (n >= 0.7 && n <= 0.9)
                {
                    g += 1500;
                }
                else
                {
                    h -= 500;
                    g -= 1000;
                    //("accident!");
                }
            }



        }

        /*惑星1個に辺り28日間の開拓期間(t)
         * 技術ポイント(g)を消費して食物（sy）を生産
         * 技術ポイントの振り方次第で食物の入手量変わる
         * 食物を消費して人(h)を増やす
         * 人の増加で取得技術ポイントが増える
         * この流れで1週間＊4回繰り返す
         * 最終日に技術ポイントの数値で星の命運決定
         * 規定値↓：星の爆発（失う）→人口半分、食料3分の1を維持して次の開拓へ
         * 規定値↑：星の維持→人口・食物すべて維持して次の開拓へ
         * 結果に関係なく次の惑星を見つける
         * 他の惑星と並行で次の惑星を開拓
         * 食料の入手量は惑星・期間ごとに違うため、食料の確保は並行してバランスよく行う必要がある
         */
    }
}
