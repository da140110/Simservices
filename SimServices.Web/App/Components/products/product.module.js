/// <reference path="../assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('simservices.products', ['simservices.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/product/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            templateUrl: "/app/components/product/productAddView.html",
            controller: "productAddController"
        });
    }

})();