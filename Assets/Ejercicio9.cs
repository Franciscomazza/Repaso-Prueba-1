using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
public class Ejercicio9 : MonoBehaviour

{
    public string persona1;
    public string persona2;
    public string persona3;

    public float CapitalAportado1;
    public float CapitalAportado2;
    public float CapitalAportado3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    float total;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nombre:" + persona1 + "capital aportado: $ " + CapitalAportado1 + "Porcentaje del capital: % " + porcentaje1 + "Monto total aportado: $" + total);
        Debug.Log("Nombre:" + persona2 + "capital aportado: $ " + CapitalAportado2 + "Porcentaje del capital: % " + porcentaje2 + "Monto total aportado: $" + total);
        Debug.Log("Nombre:" + persona3 + "capital aportado: $ " + CapitalAportado3 + "Porcentaje del capital: % " + porcentaje3 + "Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
