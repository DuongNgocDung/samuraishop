/// <reference path="../../../assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('samurai.productcategories', ['samurai.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product-categories', {
            url: "/product-categories",
            templateUrl: "/app/components/product-categories/productCategoryListView.html",
            controller: "productCategoryListController"
        });
    }
})();