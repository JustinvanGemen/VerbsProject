Shader "Custom/BMI" {
	Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _Amount ("Extrusion Amount", Range(-1,1)) = 0.5
    }
    SubShader {
      CGPROGRAM
      //pragma
      #pragma surface Surf Lambert vertex:Vert
      //variables
      sampler2D _MainTex;
      float _Amount;
      //structs
      struct Input {
          float2 mainTex;
      };
      //pragma functions
      void Vert (inout appdata_full v) {
          v.vertex.xyz += v.normal * _Amount;
      }
      void Surf (Input IN, inout SurfaceOutput output) {
          output.Albedo = tex2D (_MainTex, IN.mainTex).rgb;
      }
      ENDCG
    } 
    Fallback "Diffuse"
  }
