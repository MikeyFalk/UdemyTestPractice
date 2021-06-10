using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_WhenCalledWithNullObject_ThrowsError()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);


        }
        [Test]
        public void Push_WhenCalled_AddsObjectToStack()
        {
            var stack = new Stack<string>();
            
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        // There could be a bug in the implementation if Count is hard-coded. The following test will confirm if the list is empty 
        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            var stack = new Stack<string>();
        
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_WhenCalledWithEmptyList_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_WhenCalled_RemovesObjectFromList()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // Act
            stack.Pop();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Pop_WhenCalled_ReturnsObjectFromTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }


        [Test]
        public void Peek_WhenCalledWithEmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<String>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);

        }
        [Test]
        public void Peek_WhenCalled__ReturnsObject()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            // Act
            var result = stack.Peek();
            
            // Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]

        public void Peek_WhenCalled_DoesntRemoveObjectFromStack()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            
            // Act
            stack.Peek();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(3));



        }
    }
}
