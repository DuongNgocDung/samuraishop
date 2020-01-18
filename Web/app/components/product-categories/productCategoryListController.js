(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.dataSource = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.selectedItem = new ProductCategoryViewModel();

        $scope.GetAllData = GetAllData;
        $scope.SelectItem = SelectItem;

        function GetAllData(page) {
            page = page || 0;

            var config = {
                params: {
                    page: page,
                    pageSize: 5
                }
            }
            apiService.get('/api/product-category/get-all-paging', config, function (result) {
                if (result.data.TotalCount == 0) {
                    console.log("Không có bản ghi nào !");
                }
                $scope.dataSource = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log("load all data error");
            });
        }

        function SelectItem(item) {

        }

        //call method ?
        $scope.GetAllData();
    }
})(angular.module('samurai.productcategories'));