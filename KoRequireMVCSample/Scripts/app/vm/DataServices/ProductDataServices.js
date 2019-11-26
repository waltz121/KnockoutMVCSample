define(["jquery"],
    function ( $) {

        function InitializeProductData(productData) {
            var url = "/Product/InitializeData";

            return $.ajax({
                url: url,
                type: "GET",
                success: function (data) {
                    productData(data.ProductGridModels);
                }
            })
        }

        var vm = {
            InitializeProductData: InitializeProductData
        }

        return vm;

    });