using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimServices.Data.Infrastructure;
using SimServices.Data.Repositories;
using SimServices.Model.Models;

namespace SimServices.Service
{
    public interface IProductCategoryService 
    {
        ProductCategory Add(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        ProductCategory Delete(int id);
        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetAll(string keyword);
        IEnumerable<ProductCategory> GetAllByParentID(int parentID);
        ProductCategory GetById(int id);
        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRepository _ProductCategoryRepository;
        IUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository,IUnitOfWork unitOfWork )
        {
            _ProductCategoryRepository = ProductCategoryRepository;
            _unitOfWork = unitOfWork;

        }
        public ProductCategory Add(ProductCategory ProductCategory)
        {
            _ProductCategoryRepository.Add(ProductCategory);
            return ProductCategory;
        }

        public ProductCategory Delete(int id)
        {
            _ProductCategoryRepository.Delete(id);
            return GetById(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _ProductCategoryRepository.GetAll();
        }
        public IEnumerable<ProductCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
             return _ProductCategoryRepository.GetMulti(x=>x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _ProductCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByParentID(int parentID)
        {
            return _ProductCategoryRepository.GetMulti(x=>x.Status && x.ParentID==parentID);
        }

        public ProductCategory GetById(int id)
        {
            return _ProductCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _ProductCategoryRepository.Update(ProductCategory);
        }
    }                                                                      
}
