var url = "/Home/InitializeData";
var vmData = ko.observable();
var testVariable = ko.observable();
var testVariable2 = ko.observable();

$.ajax({
    url: url,
    type: "GET",
    success: function (data) {
        vmData(data);
        testVariable(data.TestProductVar1);
        testVariable2(data.TestProductVar2)
    }
});

function AfterInitialization(data) {
    console.log(data);
}

function Nextpage() {
    var url = "/Home/About"

    window.location.href = url;
}

function PostIt() {
    var form = {
        TestProductVar1: testVariable(),
        TestProductVar2: testVariable2()
    }

    var url = "/Home/PostTest";

    $.ajax({
        url: url,
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        data: JSON.stringify(form),
        success: function (response) {
            alert("TestProductVar1: " + response.TestProductVar1
                + ", TestProductVar2: " + response.TestProductVar2);


            window.location.href = "/Home/Contact";
        }
    });
}

var vm = {
    test: 'asdfg',
    vmData: vmData,
    testVariable: testVariable,
    testVariable2: testVariable2
};

ko.applyBindings(vm);