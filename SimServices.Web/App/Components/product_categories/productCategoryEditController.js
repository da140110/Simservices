/// <reference path="../assets/admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryEditController', productCategoryEditController);
    productCategoryEditController.$inject = ['apiService', '$scope', 'notificationService', '$state','$stateParams'];
    function productCategoryEditController(apiService, $scope, notificationService, $state, $stateParams) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status:true
        }
        $scope.UpdateProductCategory = UpdateProductCategory;
        function loadProductCategoryDetail() {
            apiService.get('api/productcategory/getbyid/' + $stateParams.id, null, function (result) {
                $scope.productCategory = result.data;
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }
        function UpdateProductCategory() {
            apiService.put('api/productcategory/update', $scope.productCategory,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được cập nhật');
                    $state.go('product_categories');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công');
                });
        }
        function LoadParentCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        LoadParentCategory();
        loadProductCategoryDetail();
    }

})(angular.module('simservices.product_categories')); 