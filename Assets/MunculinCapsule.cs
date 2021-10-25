using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinCapsule : MonoBehaviour
{
    public GameObject capsule;
    public float waktuMinimal, waktuMaximal;
    public float posisiMinimal, posisiMaximal;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculCapsule());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MunculCapsule()
    {
        Instantiate(capsule, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaximal)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal, waktuMaximal));
        StartCoroutine(MunculCapsule());
    }
}
