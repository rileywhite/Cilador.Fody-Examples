/*********************************************************************/
// This is free and unencumbered software released into the public domain.
// 
// Anyone is free to copy, modify, publish, use, compile, sell, or
// distribute this software, either in source code form or as a compiled
// binary, for any purpose, commercial or non-commercial, and by any
// means.
// 
// In jurisdictions that recognize copyright laws, the author or authors
// of this software dedicate any and all copyright interest in the
// software to the public domain. We make this dedication for the benefit
// of the public at large and to the detriment of our heirs and
// successors. We intend this dedication to be an overt act of
// relinquishment in perpetuity of all present and future rights to this
// software under copyright law.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org/>
/*********************************************************************/

using MyApplicationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    /// <summary>
    /// Runs the example program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
            var target = new Target();

            // Visual Studio won't show the Hello() method through intellisense,
            // and it may provide a visual cue that the method name is invalid
            // (e.g. red squiggly underline). It will compile, though :-)
            Console.WriteLine(target.Hello());

            // HelloAgain() is explicitly implemented in the mixin definition.
            // Because of this, it cannot be directly invoked.
            // If you uncomment this line, then Visual Studio intellisense will
            // complain identically to the above call to Hello(). This time,
            // though, it is correct in believing that the method is unavailable.
            //     (uncomment following line and try to compile to see this)
            // Console.WriteLine(target.HelloAgain());

            // Casting your target to the interface makes intellisense easier
            // to work with. It also allows you to call interface-scoped members.
            var targetAsInterface = target as MyMixinDefinitions.IHelloWorld;
            Console.WriteLine(targetAsInterface.HelloAgain());
        }
    }
}
