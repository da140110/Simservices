﻿/// <reference path="../assets/admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryAddController', productCategoryAddController);
    productCategoryAddController.$inject = ['apiService','$scope','notificationService','$state'];
    function productCategoryAddController(apiService, $scope, notificationService,$state) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status:true
        }
        $scope.AddProductCategory = AddProductCategory;

        function AddProductCategory() {
            apiService.post('api/productcategory/create', $scope.productCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công');
                });
        }
        function LoadParentCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log('Cannot get list parent')
            });
        }
        LoadParentCategory();
    }

})(angular.module('simservices.product_categories')); 