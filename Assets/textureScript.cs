using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textureScript : MonoBehaviour

{
    Tree tree1;
    public Slider mainslider;
    public Material alphamat;
    //Shader shader;

    //public Texture albedoTexture;

    void Start()
    {
       tree1 = GetComponent<Tree>();
       
        
       // meshRenderer.material.SetTexture("_Cutoff", albedoTexture);
    }

    public void AlphaSlider(float alpha)
    {
       alphamat.SetFloat("_Cutoff", alpha);
           
           
          //  Equals.SetFloat("_Cutoff", alpha);
    }

    private void Update()
    {
        
        AlphaSlider(mainslider.value);
    }
}
