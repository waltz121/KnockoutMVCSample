require.config({
    baseUrl: "/Scripts/app",
    urlArgs: version === "" ? "" : "v=" + version, // Global assembly version, set in _Layout.cshtml
    paths: {
        jquery: "../lib/jquery-3.4.1",
        bootstrap: "../lib/bootstrap",
        moment: "../lib/moment",
        domReady: "../lib/domReady",
        ko: "../lib/knockout-3.5.1"
    },
    shim: {

    }

});

require(["kickoff"], function (kickoff) {
        kickoff.init();
    }
);