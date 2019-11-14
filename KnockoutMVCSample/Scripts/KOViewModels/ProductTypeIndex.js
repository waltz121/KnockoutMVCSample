var initialData = ko.observableArray();
var url = "/ProductType/InitializeData";

$.ajax({
    url: url,
    type: "GET",
    success: function (data) {
        initialData(data.ProductTypeListModels);
    }
});

function AddProductType() {
    $("#exampleModal").modal('show');
}

var PagedGridModel = function (items) {
    this.items = ko.observableArray(items);

    this.addItem = function () {
        AddProductType();
    };

    this.sortByName = function () {
        this.items.sort(function (a, b) {
            return a.name < b.name ? -1 : 1;
        });
    };

    this.jumpToFirstPage = function () {
        this.gridViewModel.currentPageIndex(0);
    };

    this.gridViewModel = new ko.simpleGrid.viewModel({
        data: initialData,
        columns: [
            { headerText: "Product Type Code", rowText: "Product_Type_Code" },
            { headerText: "Product Type Description", rowText: "Product_Type_Description" }
        ],
        pageSize: 4
    });
};

ko.applyBindings(new PagedGridModel(initialData()));