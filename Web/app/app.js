/// <reference path="../assets/admin/libs/angular/angular.js" />
// khai báo 1 module mới
// cái thằng module samurai này là chính và nó add hết tất cả các module con khác

(function () {
    angular.module('samurai', ['samurai.common', 'samurai.products', 'samurai.productcategories']).config(config);

    //tiêm 2 cái provider này vào đây
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    //và trong function này nó có thể tự nhận
    //cấu hình routing cho cái samurai này, 
    function config($stateProvider, $urlRouterProvider) {
        //đây là khai báo cho cái đường danẫ admin này nó sẽ dẫn tới cái homeView kia và sử dụng homeController
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });

        //khi mà không có trường hợp nào ở trên thì nó sẽ tự động đi vào đường dẫn này
        $urlRouterProvider.otherwise('/admin');
    }
})();