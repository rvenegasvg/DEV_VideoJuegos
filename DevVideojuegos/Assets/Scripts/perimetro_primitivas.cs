using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perimetro_primitivas : MonoBehaviour
{
    public enum Perimetro
    {
        circulo,
        cuadrado,
        rectangulo,
        triangulo
    }
   
    
    public Perimetro opcion = Perimetro.rectangulo;
    public int[] circulo;
    public int[] cuadrado;
    public int[] rectangulo;
    public int[] triangulo;

   // [System.Serializable]
   // int[] dato;

    private void Start()
    {
        Seleccion();
    }



    void Seleccion()
    {
        switch (opcion)
        {
            case Perimetro.circulo:
                Debug.Log("mi valor es: "+calculo_circuclo(circulo));
                break;
            case Perimetro.cuadrado:
                Debug.Log("mi valor es: " + calculo_cuadrado(cuadrado)) ;
                break;
            case Perimetro.rectangulo:
                Debug.Log("mi valor es: "+ calculo_rectangulo(rectangulo));
                break;
            case Perimetro.triangulo:
                Debug.Log("mi valor es: "+ calculo_triangulo(triangulo));
                break;
        }




    }

    int calculo_circuclo(int[] valor)
    {
        int calculo = 0;

        calculo = 2 * 3 * valor[0];

        return calculo;
    }

    int calculo_cuadrado(int[] valor)
    {
        int calculo = 0;

        calculo = valor[0]+valor[1]+valor[2]+valor[3];

        return calculo;
    }
    int calculo_triangulo(int[] valor)
    {
        int calculo = 0;

        calculo = valor[0] + valor[1] + valor[2];

        return calculo;
    }
    int calculo_rectangulo(int[] valor)
    {
        int calculo = 0;

        calculo = valor[0] + valor[1] + valor[2] + valor[3];

        return calculo;
    }
}
