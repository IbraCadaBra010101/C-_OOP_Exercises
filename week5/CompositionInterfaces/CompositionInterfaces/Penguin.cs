using System;

namespace CompositionInterfaces
{
    class Penguin: Animal, ISwimmer, IWalker
    {
        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}