/// <reference path="../assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('simservices.products', ['simservices.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('products', {
                url: "/products",
                parent:'base',
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            parent: 'base',
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        });
    }
})();