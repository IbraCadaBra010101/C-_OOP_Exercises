using System;

namespace CompositionInterfaces
{
    class Fish: Animal, ISwimmer
    {
        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}