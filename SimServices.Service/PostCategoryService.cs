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
    public interface IPostCategoryService 
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentID(int parentID);
        PostCategory GetById(int id);
        void Save();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository,IUnitOfWork unitOfWork )
        {
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;

        }
        public PostCategory Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
            return postCategory;
        }

        public PostCategory Delete(int id)
        {
            _postCategoryRepository.Delete(id);
            return GetById(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentID)
        {
            return _postCategoryRepository.GetMulti(x=>x.Status && x.ParentID==parentID);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }                                                                      
}
