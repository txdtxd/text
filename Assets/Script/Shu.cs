using UnityEngine;
using System.Collections;

public class Shu : MonoBehaviour
{
    public int Hp = 100;
    private int HpMax = 100;
    public UISlider slider;
    public UILabel label;
    public UIButton button;
    public int num;
    public Explain explain;

    void Update()
    {
        slider.value = (float)Hp / HpMax;
        label.text = Hp + "/" + HpMax;

        if (Hp <= 0)
        {
            explain.Over("游戏失败");
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "trap")
        {
            int hurt = Random.Range(1, 21);
            Hp -= hurt;
        }
    }

    public void AddHp()
    {
        num++;
        if (num >= 3)
        {
            button.isEnabled = false;
        }
        Hp += 20;
        if (Hp >= 100)
        {
            Hp = 100;
        }
    }
}
