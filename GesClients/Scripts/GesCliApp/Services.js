app.service("GesClientsService", function ($http) {
    var url = 'api/Clientes';
    this.getClientes = function () {
        return $http.get(url).then(function (response) {
            return response.data;
        });
    }
    this.saveClientes = function (cli) {
        return $http({
            method: 'post',
            data: cli,
            url: 'api/Clientes'
        });
    }
});