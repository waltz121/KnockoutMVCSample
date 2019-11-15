define(["ko","jquery"],
    function (ko, $) {

        function InitializeProductTypeData(vm) {
            var url = "/ProductType/InitializeData";

            $.ajax({
                url: url,
                type: "GET",
                success: function (data) {
                    vm(data.ProductTypeListModels);
                }
            });
        }

        function AddProductType(productType) {
            var url = "/ProductType/AddProductType";

            $.ajax({
                url: url,
                type: "POST",
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                data: JSON.stringify(productType()),
                success: function (response) {
                    console.log("Save Successful!");
                }
            });
        }

        var vm = {
            InitializeProductTypeData: InitializeProductTypeData,
            AddProductType: AddProductType
        };

        return vm;

    });
