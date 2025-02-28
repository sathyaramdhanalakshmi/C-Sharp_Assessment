using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double total);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total)
        {
            return total; // No discount applied
        }
    }
    public class PercentageDiscount : IDiscountStrategy
    {
        private double _percentage;
        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }
        public double ApplyDiscount(double total)
        {
            return total - (total * _percentage / 100);
        }
    }
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private double _amount;
        public FixedAmountDiscount(double amount)
        {
            _amount = amount;
        }
        public double ApplyDiscount(double total)
        {
            return total - _amount;
        }
    }

    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateFinalAmount(double total)
        {
            return _discountStrategy.ApplyDiscount(total);
        }
    }
}
