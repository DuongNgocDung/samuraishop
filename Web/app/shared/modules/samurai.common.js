//theo phương pháp gối đầu
//chúng ta add cái reference ui router này vào trong cái common này, sau đó
//ai sử dụng cái commmon này đều có thể sử dụng cái ui.router
///MỤC TIÊU : Include những cái directive bên ngoài
(function () {
    angular.module('samurai.common', ['ui.router'])
})();