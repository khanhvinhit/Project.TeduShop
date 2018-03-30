/// <reference path="../plugins/angular/angular.js" />
//0
var myApp = angular.module('myModule', []);
//1
myApp.controller("schoolController", schoolController);

myApp.directive("teduShopDirective", teduShopDirective);

myApp.service('validatorService', validatorService);

schoolController.$inject = ['$scope', 'validatorService'];

//2
function schoolController($scope, validatorService) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function validatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else
            return 'This is odd';
    }
}
function teduShopDirective() {
    return {
        templateUrl: "/Scripts/spa/teduShopDirective.html"
    }
}