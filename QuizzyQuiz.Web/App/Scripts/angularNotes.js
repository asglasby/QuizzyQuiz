function Controller($scope) {
    $scope.firstBoundVariable = "I can set variables from JS";
    $scope.Reverse = function () {
        $scope.firstBoundVariable = $scope.firstBoundVariable.split("").reverse().join("");
    }

    $scope.Reverse2 = function (data) {
        $scope.BoundVariable = data.split("").reverse().join("");
    }
}

var app = angular.module("myApp", ['ngRoute']);

//app.config(function ($routeProvider, $httpProvider) {
//    $routeProvider.when('/', {
//        controller: 'MyController',
//        templateUrl: 'index.html'
//    })
//})

app.controller('MyController', function ($scope, $http) {
    $scope.Submit = function () {
        $http({ method: "POST", url: "/api/v1/Quiz", data: $scope.Quiz })
        .success(function () {
            $scope.GetAll();
        })
    }

    $scope.GetAll = function () {
        $http({ method: "GET", url: "/api/v1/Quiz" })
        .success(function (data) {
            $scope.quizs = data;
        })
    }
});