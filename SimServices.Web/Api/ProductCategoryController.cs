using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimServices.Model.Models;
using SimServices.Service;
using SimServices.Web.Infrastructure.Core;
using SimServices.Web.Infrastructure.Extensions;
using SimServices.Web.Models;

namespace SimServices.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryService _productCategoryService;

        public ProductCategoryController(IErrorService errorService, IProductCategoryService productCategoryService) : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request, string keyword, int page, int pageSize)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalRow = 0;
                var model = _productCategoryService.GetAll(keyword);
                totalRow = model.Count();
                var query = model.OrderByDescending(x => x.CreatedDate).Skip(page * pageSize).Take(pageSize);
                var responseData = AutoMapper.Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(query);
                var paginationSet = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = responseData,
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };
                var response = request.CreateResponse(HttpStatusCode.OK, paginationSet);
                return response;
            });
        }
        [Route("getbyid/{id:int}")]
        [HttpGet]
        public HttpResponseMessage GetByID(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetById(id);

                 var responseData = AutoMapper.Mapper.Map<ProductCategory, ProductCategoryViewModel>(model);
                 var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("getallparents")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetAll();
                var responseData = AutoMapper.Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("create")]
        [HttpPost]
        public HttpResponseMessage Create(HttpRequestMessage request, ProductCategoryViewModel productCategoryVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage respose = null;
                if (!ModelState.IsValid)
                {
                    respose = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var newProductCategory = new ProductCategory();
                    newProductCategory.UpdateProductCategory(productCategoryVM);
                    _productCategoryService.Add(newProductCategory);
                    _productCategoryService.Save();
                    var resposeData = AutoMapper.Mapper.Map<ProductCategory, ProductCategoryViewModel>(newProductCategory);
                    respose = request.CreateResponse(HttpStatusCode.Created, resposeData);
                }
                return respose;
            });
        }
        [Route("update")]
        [HttpPut]
        [AllowAnonymous]
        public HttpResponseMessage Update(HttpRequestMessage request, ProductCategoryViewModel productCategoryVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage respose = null;
                if (!ModelState.IsValid)
                {
                    respose = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var dbProductCategory = _productCategoryService.GetById(productCategoryVM.ID);
                    dbProductCategory.UpdateProductCategory(productCategoryVM);
                    _productCategoryService.Update(dbProductCategory);
                    _productCategoryService.Save();
                    var resposeData = AutoMapper.Mapper.Map<ProductCategory, ProductCategoryViewModel>(dbProductCategory);
                    respose = request.CreateResponse(HttpStatusCode.Created, resposeData);
                }
                return respose;
            });
        }
        [Route("delete")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage respose = null;
                if (!ModelState.IsValid)
                {
                    respose = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var oldProductCategory =_productCategoryService.Delete(id);
                    _productCategoryService.Save();
                    var resposeData = AutoMapper.Mapper.Map<ProductCategory, ProductCategoryViewModel>(oldProductCategory);
                    respose = request.CreateResponse(HttpStatusCode.Created, resposeData);
                }
                return respose;
            });
        }
    }
}