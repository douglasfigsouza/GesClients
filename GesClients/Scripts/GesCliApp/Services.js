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
    this.updateCliente = function (cli) {
        return $http({
            method: 'put',
            data: cli,
            url: 'api/Clientes'
        });
    }
    this.DeleteCliente = function (id) {
        var url = 'api/Clientes/' + id;
        return $http({
            method: 'delete',
            data:id,
            url:url
        });
    }
});