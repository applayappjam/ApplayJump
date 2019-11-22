using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootholdGenerator : MonoBehaviour
{
    public GameObject footholdPrefab;
    float span = 1.0f;
    float delta = 0;
    float py = 0;
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            
            this.delta = 0;
            GameObject foothold = Instantiate(footholdPrefab) as GameObject;
            // x축 최소 수치 ~ 최댓값에서 생성
            float px = Random.Range(-1.91f, 1.88f);
            foothold.transform.position = new Vector2(px, py);
            py += 2.0f;

            // todo
            // py가 캐릭터의 이동에 따라 생성되게
        }
                
    }
}