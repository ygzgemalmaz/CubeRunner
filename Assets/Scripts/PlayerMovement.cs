using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* nesnenin fiziksel hareketini yönlendirmek için rigibody ile rb adını verdik ve unityde rigibodyi içine attık */
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    
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
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); // public floatla forwardforce tanımladık ve artık hızı kendimiz ekliyoruz
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce *  Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 );
        }

    }
}
