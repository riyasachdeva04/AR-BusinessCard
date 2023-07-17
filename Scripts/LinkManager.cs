using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;


public class LinkManager : MonoBehaviour
{

    public void openLocation()
    {
        Application.OpenURL("https://www.google.com/maps/dir//Koramangala,+Bengaluru,+Karnataka/@12.8714599,77.6437842,10.04z/data=!4m9!4m8!1m0!1m5!1m1!1s0x3bae144ed898fc2d:0x1681f38e8c00ae56!2m2!1d77.6244807!2d12.9351929!3e0?entry=ttu");
    }

    public void openGmail()
    {
        Application.OpenURL("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSGMhgFzvJgsnGzsmNNRRFqpBVvHLXFcqGsPrRJRldQjBKJbQvshMxvvnBjkLvJvzQZCKrZC");        
    }

    public void openSimplismart()
    {
        Application.OpenURL("https://simplismart.ai/");        
    }

    public void openQR()
    {
        Application.OpenURL("https://www.linkedin.com/in/pranay-chauhan/");
    }

}
