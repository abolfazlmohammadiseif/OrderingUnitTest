using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Models
{
    public interface IOrderRepository
    {
        Task<int> InsertOrder(Order order);
    }
}
