using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Downstairs : MonoBehaviour
{
    private const int downstairsId = 99;

    void OnCollisionStay(Collision coll)
    {
        Tile ti = coll.gameObject.GetComponent<Tile>();

        if (ti == null) return;

        if (ti.tileNum == downstairsId) SceneManager.LoadScene("_Scene_Hat");
    }
}
