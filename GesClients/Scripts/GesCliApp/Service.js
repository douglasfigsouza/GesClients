app.service("GesClientsService", function ($http) {
    var url = 'api/Clientes';
    this.saveClientes = function (cli) {
        return $http({
            method: 'post',
            data: cli,
            url: 'api/Clientes'
        });
    }
});