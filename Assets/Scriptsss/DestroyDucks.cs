﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDucks : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Clone")
        {
            Debug.Log("Destroying the duck.");
            Destroy(collision.gameObject);
        }
    }
}
