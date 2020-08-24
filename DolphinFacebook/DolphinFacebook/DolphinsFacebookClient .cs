using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;


namespace DolphinFacebook
{
    class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        private IDisplay _display;

        public DolphinsFacebookClient(IDisplay display)
        {
            _display = display;
        }
        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += _display.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= _display.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            
            NewWallPost?.Invoke(wallPost);
          
        }
    }
}
