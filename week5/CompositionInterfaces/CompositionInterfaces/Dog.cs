using System;

namespace CompositionInterfaces
{
    class Dog: Animal, IWalker
    {
        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}