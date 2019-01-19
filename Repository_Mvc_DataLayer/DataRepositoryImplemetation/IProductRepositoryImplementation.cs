using Repository_Mvc_DataLayer.DataEntity;
using Repository_Mvc_DataLayer.DataGenericRepository;
using System.Web;

namespace Repository_Mvc_DataLayer.DataRepositoryImplemetation
{
    interface IProductRepositoryImplementation : IGenericRepository<Product>
    {
        void  SaveArchive( string caminho,HttpPostedFileBase arquivo);
    }
}
