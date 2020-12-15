using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using КурсовойПроект.Domain.Entities;

namespace КурсовойПроект.Domain.Repositories.Abstract
{
    public class IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity){}
        void DeleteServiceItem(Guid id){}
    }
}
