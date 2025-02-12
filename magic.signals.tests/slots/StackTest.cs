/*
 * Magic Cloud, copyright Aista, Ltd. See the attached LICENSE file for details.
 */

using magic.node;
using magic.signals.contracts;

namespace magic.signals.tests.slots
{
    [Slot(Name = "stack.test")]
    public class StackTest : ISlot
    {
        public void Signal(ISignaler signaler, Node input)
        {
            input.Value = signaler.Peek<string>("value");
        }
    }

    [Slot(Name = "stack.test.dispose")]
    public class StackTestDispose : ISlot
    {
        public void Signal(ISignaler signaler, Node input)
        {
            input.Value = signaler.Peek<object>("value.dispose").ToString();
        }
    }
}
