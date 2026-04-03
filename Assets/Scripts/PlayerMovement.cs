using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* nesnenin fiziksel hareketini yönlendirmek için rigibody ile rb adını verdik ve unityde rigibodyi içine attık */
    public Rigidbody rb;
    
    
        /* oyun başladıgında konsolda yazı gösterir
           Debug.Log("Hello, World!");
        */

        /*   yer çekimini kapattık
     rb.useGravity = false;
        */

        /* uyguladıgımız kuvvetin büyüklüğünü ve eksenlerini addforce ile ekledik
        rb.AddForce(0, 200, 500);
        */
    

    // Update is called once per frame

    //kuvvet hız gibi özellikler eklerken fixed update kullanmamız daha iyi olur unity bunu kendi yapar
    void FixedUpdate()
    {
        /* Ekran yenilemesi yüksek bilgisayarın avantajını kaldırdık*/
        rb.AddForce(0, 0, 2000*Time.deltaTime);
    }
}
