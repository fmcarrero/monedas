var base = (function () {

    return {

        ajaxJson: function(url,data,type){
            return $.ajax({
                type: type,
                url: url,
                data: data,
                dataType: "json"
            });
        }
    }
}());