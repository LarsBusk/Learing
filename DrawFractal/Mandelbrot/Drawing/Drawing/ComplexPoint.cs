using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing {
    /// <summary>
    /// ComplexPoint class is used encapsulate a single complex point
    /// Z = x + i*y where x and y are the real and imaginary parts respectively.
    /// A number of complex arithmetic utility methods are provided.
    /// </summary>
    public class ComplexPoint {
        public double real;
        public double img;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="real">real part of complex point</param>
        /// <param name="img">imaginary part of complex point</param>
        public ComplexPoint(double real, double img) {
            this.real = real;
            this.img = img;
        }

        /// <summary>
        /// Calculate the modulus |Z| = Sqrt(x*x + y*y).
        /// </summary>
        /// <returns>Modulus of complex point</returns>
        public double DoModulus() {
            return Math.Sqrt(DoMoulusSq());
        }

        /// <summary>
        /// Calculate modulus squared |Z|**2 = X*x + y*y.
        /// </summary>
        /// <returns>Modulus squared</returns>
        public double DoMoulusSq()
        {
          return real * real + img * img;
        }

        /// <summary>
        /// Calculate the square of complex point, Z**2. The
        /// result is another complex number: (x*x - y*y) + i*2*x*y.
        /// </summary>
        /// <returns>Square of complex point</returns>
        public ComplexPoint DoCmplxSq()
        {
            return new ComplexPoint(
              real * real - img * img, 
              2 * real * img); 
        }

        /// <summary>
        /// Add complex value, arg, to this complex point, Z. The result is
        /// another complex number.
        /// </summary>
        /// <param name="arg">Complex number to add</param>
        /// <returns>Z + arg</returns>
        public ComplexPoint doCmplxAdd(ComplexPoint arg)
        {
            real += arg.real;
            img += arg.img;

            return this;
        }

        /// <summary>
        /// Calculate complex square plus complex constant. The result
        /// is another complex number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns>Z**2 + arg</returns>
        public ComplexPoint DoCmplxSqPlusConst(ComplexPoint arg)
        {
          ComplexPoint result = DoCmplxSq(); //new ComplexPoint(0, 0);

          //result.real = real * real - img * img;
            //result.img = 2 * real * img;
            result.real += arg.real;
            result.img += arg.img;
            return result;
        }
    }
}
