require(["ko", "jquery", "vm/DataServices/ProductDataServices"],
    function (ko, $, ProductDataServices) {
        var title = ko.observable("Product Manager");
        var ProductList = ko.observableArray();

        var EditProduct_Id = ko.observable(),
            EditProduct_UnitPrice = ko.observable(),
            EditProduct_ProductName = ko.observable(),
            EditProduct_ProductDescription = ko.observable(),

            EditProductImage_ID = ko.observable(),
            EditProductImage_ProductID = ko.observable(),
            EditProductImage_Image = ko.observable(),
            EditProductImage_Description = ko.observable();

        function init() {
            ProductDataServices.InitializeProductData(ProductList);
        }

        function AddProduct() {
            console.log("Add Works!");
        }

        function EditProduct(item) {
            EditProduct_Id(item.Id);
            EditProduct_UnitPrice(item.Unit_Price);
            EditProduct_ProductName(item.Product_Name);
            EditProduct_ProductDescription(item.Product_Description);
        }

        init();
        //================================== Camera Specific =================
        const player = document.getElementById('player');
        const canvas = document.getElementById('canvas');
        const context = canvas.getContext('2d');
        const captureButton = document.getElementById('capture');

        const constraints = {
            video: true,
        };

        

        captureButton.addEventListener('click', () => {
            context.drawImage(player, 0, 0, canvas.width, canvas.height);

            // Stop all video streams.
            player.srcObject.getVideoTracks().forEach(track => track.stop());
        });

        navigator.mediaDevices.getUserMedia(constraints)
            .then((stream) => {
                // Attach the video stream to the video element and autoplay.
                player.srcObject = stream;
            });


         //===============================================================
        var vm = {
            title: title,
            ProductList: ProductList,
            AddProduct: AddProduct,
            EditProduct: EditProduct,

            EditProduct_Id: EditProduct_Id,
            EditProduct_UnitPrice: EditProduct_UnitPrice,
            EditProduct_ProductName: EditProduct_ProductName,
            EditProduct_ProductDescription: EditProduct_ProductDescription,

            EditProductImage_ID: EditProductImage_ID,
            EditProductImage_ProductID: EditProductImage_ProductID,
            EditProductImage_Image: EditProductImage_Image,
            EditProductImage_Description: EditProductImage_Description
        }

        ko.applyBindings(vm);

    });