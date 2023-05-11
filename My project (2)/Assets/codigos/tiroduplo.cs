using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroduplo : MonoBehaviour
{
    public GameObject bulletPrefab; // referência ao prefab da bala
    public Transform firePoint; // referência ao ponto de origem do tiro

    public void FireDoubleShot()
    {
        // Cria uma nova bala no ponto de origem
        GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    
        // Cria uma segunda bala com uma pequena diferença de rotação
        Quaternion rotationOffset = Quaternion.Euler(0, 15, 0); // ajuste o valor do eixo Y para alterar o ângulo do segundo tiro
        GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation * rotationOffset);
    }
}
