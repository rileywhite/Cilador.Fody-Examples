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

using MyMixinDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMixinImplementations
{
    /// <summary>
    /// This is the mixin implementation. The FodyWeavers.xml
    /// configuration specifies that this is the type that should
    /// be used to implement the IHelloWorld mixin definition.
    /// 
    /// All code within this type will be copied into the mixin target
    /// with the exception of constructors and field initializations.
    /// </summary>
    public class HelloMixin : IHelloWorld
    {
        public string Hello()
        {
            return "Hello World";
        }

        string IHelloWorld.HelloAgain()
        {
            return "Hello, again, this time with an explicit implementation.";
        }

        public string HelloEcho<T>(T input)
        {
            return input == null ? "Null" : input.ToString();
        }
    }
}
