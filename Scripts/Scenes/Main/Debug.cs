using Godot;

namespace GodotModules 
{
    public class Debug : Node 
    {
        public override void _Input(InputEvent @event)
        {
            if (Input.IsActionJustPressed("ui_test"))
            {
                GetTree().Root.PrintStrayNodes();
            }
        }
    }
}