using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extenderGroup : MonoBehaviour
{
    public Animator[] anime;
    private void Start()
    {
        anime[0].enabled = false;
        anime[1].enabled = false;
        anime[2].enabled = false;
        anime[3].enabled = false;
    }

    #region ex_1
    public void ex_1_Start()
    {
        anime[0].enabled = true;
    }
    public void ex_1_end()
    {
        anime[0].enabled = false;
    }
    #endregion
    #region ex_2
    public void ex_2_Start()
    {
        anime[1].enabled = true;
    }
    public void ex_2_end()
    {
        anime[1].enabled = false;
    }
    #endregion
    #region ex_3
    public void ex_3_Start()
    {
        anime[2].enabled = true;
    }
    public void ex_3_end()
    {
        anime[2].enabled = false;
    }
    #endregion
    #region ex_4
    public void ex_4_Start()
    {
        anime[3].enabled = true;
    }
    public void ex_4_end()
    {
        anime[3].enabled = false;
    }
    #endregion

}
