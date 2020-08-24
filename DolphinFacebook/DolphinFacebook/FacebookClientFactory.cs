using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;


namespace DolphinFacebook
{
    class FacebookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            DolphinsFacebookClient dolphinsFacebookClient = new DolphinsFacebookClient(display);
            return dolphinsFacebookClient;
        }
    }
}
