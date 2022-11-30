using System;
namespace RoboKitten.Casting;
public class Artifact : Actor
    {
        //SPAWNS ARTIFACTS WITH MESSAGES ATTATCHED
        private string _message = "";

        public Artifact()
        {
        }

        public string GetMessage()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            this._message = message;
        }
    }