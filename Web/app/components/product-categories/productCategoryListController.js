(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.dataSource = [];
        $scope.getAllData = getAllData;

        function getAllData() {
            apiService.get('/api/product-category/get-all', null, function (result) {
                $scope.dataSource = result.data;
            }, function (error) {
                    console.log("load all data error", error);
            });
        }

        //call method ?
        $scope.getAllData();
    }
})(angular.module('samurai.productcategories'));