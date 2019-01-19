using System.IO;
using System.Web;
using Repository_Mvc_DataLayer.DataEntity;
using Repository_Mvc_DataLayer.DataGenericRepository;


namespace Repository_Mvc_DataLayer.DataRepositoryImplemetation
{
    public class ProductRespositotryImplementation : GenericRepository<Product>, IProductRepositoryImplementation
    {
        public void SaveArchive( string caminho, HttpPostedFileBase arquivo)
        {

            arquivo.SaveAs(caminho);
           
        }
    }
}
