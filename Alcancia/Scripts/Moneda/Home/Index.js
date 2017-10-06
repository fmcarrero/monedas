var HomeIndex = new function () {
    var init = function () {
        CargarTiposMoneda();
        getsuma(getDetalles);
        //getDetalles();

    };
    var getDetalles = function () {
        base.ajaxJson("/Moneda/getDetalles", {}, "Post").done(function (data) {
            $.each(data, function (index, tipo) {
                $("#detalles tbody").append("<tr><td>" + tipo.NombreMoneda + "</td><td>" + tipo.Cantidad + "</td></tr>")
            })

            console.log(data);
           

        }).fail(function (error) {
            console.log(error);
        });

       
    }
    var getsuma = function (_callback) {
        base.ajaxJson("/Moneda/GetSumaAlcancia", {}, "Post").done(function (data) {
            $("#total").val(data);
            if (_callback) {
                _callback();
            }
        })
            .fail(function (error) {

            })
    }
    var CargarTiposMoneda = function () {
        base.ajaxJson("/Moneda/GetAll", {}, "Post").done(function (data) {
            
            $.each(data, function (index, moneda) {
                $("#TipoMoneda").append("<option value='" + moneda.TipoMoneda + "'>" + moneda.NombreMoneda + "</option>")
            });

        }).fail(function (error) {
            console.log(error);
        })
    }
    this.init = init;
}

new HomeIndex.init();