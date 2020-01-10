﻿/// <reference path="../../../assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('samurai.products', ['samurai.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('product-add', {
            url: "/product-add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        }).state('product-edit', {
            url: "/product-edit",
            templateUrl: "/app/components/products/productEditView.html",
            controller: "productEditController"
        });
    }
})();