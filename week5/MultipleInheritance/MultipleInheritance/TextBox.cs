using System;

namespace MultipleInheritance
{
    public class TextBox : UiControl, Idraggable, Idroppable
    {
        public void Drag()
        {
            Draw();
            Focus();
        }
    }
}