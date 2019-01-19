using Repository_Mvc_DataLayer.DataEntity;
using Repository_Mvc_DataLayer.DataRepositoryImplemetation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Mvc_ApplicationLayer.ApplicationImplementation
{
    public class ProductApplication
    {
        private ProductRespositotryImplementation productRespositotryImplementation = new ProductRespositotryImplementation();

        public ProductApplication()
        {

        }

        public List<Product> GetProduct(int ID = -1)
        {
            try
            {
                if (ID == -1)
                {
                    return productRespositotryImplementation.GetAll().ToList();
                }
                else
                {
                    return productRespositotryImplementation.Get(x=>x.Id == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                productRespositotryImplementation.Add(product);
                productRespositotryImplementation.Commit();

            }catch(Exception ex)
            {
                throw ex;
            }

        }

        public Product FindProduct(int? id)
        {
            try
            {
                return productRespositotryImplementation.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void RemoveProduct(Product product)
        {
            try
            {
                productRespositotryImplementation.Delete( x=> x == product);
                productRespositotryImplementation.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                productRespositotryImplementation.Update(product);
                productRespositotryImplementation.Commit();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void SaveArchive(string path, HttpPostedFileBase archive)
        {
            try
            {
                productRespositotryImplementation.SaveArchive(path,archive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
    }
}
