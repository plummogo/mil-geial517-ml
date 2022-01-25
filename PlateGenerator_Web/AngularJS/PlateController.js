angular.module('plateApp', []).controller('PlateController', ($scope, $http, $location, $window) => {
    $scope.plateModel = {};
    $scope.message = '';
    $scope.result = "color-default";
    $scope.toggleLoading = false;
    $scope.plates = null;
    getallData();

    getallData = () => {
        $http.get('/Home/GetAll')
            .success((data, status, headers, config) => { $scope.plates = data; })
            .error((data, status, headers, config) => {
                $scope.message = 'Unexpected Error while loading plates!';
                $scope.result = "color-red";
                console.log($scope.message);
            });
    };

    $scope.getPlate = (plateModel) => {
        $http.get('/Home/Get/' + plateModel.Id)
            .success((data, status, headers, config) => { $scope.plateModel = data; getallData(); })
            .error((data, status, headers, config) => {
                $scope.message = 'Unexpected Error while loading selected plate!';
                $scope.result = "color-red";
                console.log($scope.message);
            });
    };

    $scope.saveCustomer = () => {
        $scope.toggleLoading = true;

        $http({
            method: 'POST',
            url: '/Home/Create',
            data: $scope.plateModel
        }).success((data, status, headers, config) => {
            if (data.success) {
                $scope.message = 'Form data Saved!';
                $scope.result = "color-green";
                getallData();
                $scope.plateModel = {};
            }
            else {
                $scope.message = 'Form data not Saved!';
                $scope.result = "color-red";
            }
        }).error((data, status, headers, config) => {
            $scope.message = 'Unexpected Error while saving plate! ' + data.errors;
            $scope.result = "color-red";
            console.log($scope.message);
        });

        getallData();
        $scope.toggleLoading = false;
    };

    $scope.updatePlate = () => {
        $scope.toggleLoading = true;
        $http({
            method: 'POST',
            url: '/Home/Update',
            data: $scope.plateModel
        }).success((data, status, headers, config) => {
            if (data.success) {
                $scope.plateModel = null;
                $scope.message = 'Selected plate was updated!';
                $scope.result = "color-green";
                getallData();
            }
            else {
                $scope.message = 'Selected plate was not updated!';
                $scope.result = "color-red";
            }
        }).error((data, status, headers, config) => {
            $scope.message = 'Unexpected error while updating plate! ' + data.errors;
            $scope.result = "color-red";
            console.log($scope.message);
        });

        $scope.toggleLoading = false;
    };

    $scope.deletePlate = (plateModel) => {
        const confirmed = confirm('You are about to delete ' + plateModel.Id + '. Are you sure?');

        if (confirmed) {
            $http.delete('/Home/Delete/' + plateModel.Id)
                .success((data, status, headers, config) => {
                    if (data.success) {
                        $scope.message = plateModel.Id + ' deleted from plates!!';
                        $scope.result = "color-green";
                        getallData();
                    }
                    else {
                        $scope.message = 'Selected plate was not deleted!';
                        $scope.result = "color-red";
                    }
                })
                .error((data, status, headers, config) => {
                    $scope.message = 'Unexpected error while deleting plate!!';
                    $scope.result = "color-red";
                    console.log($scope.message);
                });
        }
    };
})
    .config(function ($locationProvider) {
        $locationProvider.html5Mode(true);
    });