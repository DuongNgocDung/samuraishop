/// <reference path="../../../assets/admin/libs/angular/angular.js" />
//đây là 1 cái service dùng chung cho tất cả

(function (app) {
    app.service('apiService', apiService);
    apiService.$inject = ['$http'];

    function apiService($http) {
        return {
            get: get
        }

        function get(url, params, sucessed, failed) {
            $http.get(url, params).then(function (result) {
                sucessed(result);
            }, function (error) {
                failed(error);
            });
        }
    }
})(angular.module('samurai.common'));