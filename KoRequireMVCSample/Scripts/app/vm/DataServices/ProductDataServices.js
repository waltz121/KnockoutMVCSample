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
            });
        }

        function SaveProductImage(addProductImageModel) {
            var url = "/Product/SaveProductImage";

            return $.ajax({
                url: url,
                type: "POST",
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                data:  JSON.stringify(addProductImageModel),
                success: function (data) {
                    console.log(data);
                },
                error: function (response) {
                    console.log("Save Failed : " + response);
                }
            });
        }

        function UploadImage(imageVM) {
            var image = imageVM.toDataURL("image/png");

            image = image.replace('data:image/png;base64,', '');

            $.ajax({
                type: "POST",
                url: "/Product/UploadImage",
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                data: '{ "imageData" : "' + image + '" }',
                success: function (msg) {
                    console.log('Image saved successfully !');
                },
                error: function (response) {
                    console.log("Save Failed : " + response);
                }
            });
        }

        var vm = {
            InitializeProductData: InitializeProductData,
            SaveProductImage: SaveProductImage,
            UploadImage: UploadImage
        }

        return vm;

    });