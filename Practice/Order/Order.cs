using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Order
{
    internal class Order
    {
        public int orderNum { get; set; }
        public string custName { get; set; }
        public int quantityOrdered { get; set; }
        public double  totalPrice { get; }

        public Order(int orderNum,string custName,int quantityOrdered )
        {
            this.orderNum = orderNum;
            this.custName = custName;
            this.quantityOrdered = quantityOrdered;
            totalPrice = quantityOrdered * 19.95;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                Order other = obj as Order;
                if (this.orderNum == other.orderNum )
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (orderNum);
        }

        public override string ToString()
        {
            return $"Customer Name: {custName}   Order Number: {orderNum}    Qauntity:{quantityOrdered}     Total price:{totalPrice}";
        }
    }
}
