using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatterns
{
    public class Account
    {
        // тип учетной записи
        public IType Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(IType type, double interest, double balance)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
        public void Calculate()
        {
            Type.Calculate(this);
            Console.WriteLine(this.Interest);
        }
    }
}
