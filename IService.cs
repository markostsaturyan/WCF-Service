using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IService
    {
        [OperationContract]
        Result Add(Book book);
        [OperationContract]
        Result UpdatePrice(int id,double price);
    }
}
