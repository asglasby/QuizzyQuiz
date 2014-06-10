"use strict";
var app = angular.module("myApp", ['ngRoute']);

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