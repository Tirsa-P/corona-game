using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MunculinVirus : MonoBehaviour
{
    public GameObject virus;
    public GameObject capsule;
    public float waktuMinimalv, waktuMaximalv,waktuMinimalc,waktuMaximalc;
    public float posisiMinimal, posisiMaximal;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
        StartCoroutine(MunculCapsule());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (score == 100)
        {
            waktuMinimalv = 0.9f;
          
        }
        if (score == 200)
        {
            waktuMinimalv = 0.6f;
            waktuMaximalv = 1;
        }if (score == 300)
        {
            waktuMinimalv = 0.3f;
            waktuMaximalv = 0.5f;
        }
    }

    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaximal)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimalv,waktuMaximalv));
        StartCoroutine(MunculVirus());
    }
    IEnumerator MunculCapsule()
    {
        Instantiate(capsule, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaximal)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimalc,waktuMaximalc));
        StartCoroutine(MunculCapsule());
    }

}
