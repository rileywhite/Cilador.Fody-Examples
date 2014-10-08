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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMixinDefinitions
{
    /// <summary>
    /// This is the mixin definition interface. This inteface
    /// will be added to the target type in MyApplicationLibrary.dll.
    /// </summary>
    public interface IHelloWorld
    {
        /// <summary>
        /// When implemented, this should return a simple hello message.
        /// </summary>
        /// <returns>Simple hello message</returns>
        string Hello();

        /// <summary>
        /// When implemented, this should return a simple hello again message.
        /// </summary>
        /// <returns>Simple hello message</returns>
        string HelloAgain();

        /// <summary>
        /// When implemented, this should echo back the callers input as a string.
        /// </summary>
        /// <typeparam name="T">Type of input.</typeparam>
        /// <param name="input">Input to echo as a string.</param>
        /// <returns>Input as a string.</returns>
        string HelloEcho<T>(T input);
    }
}
